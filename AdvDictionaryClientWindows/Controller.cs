using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountTransactions;

namespace AdvDictionaryClientWindows
{
    

    public static class Controller
    {
        static Account Account { get; set; }
        static Language CurrentLanguage { get; set; }
        static SortingVariants SortingVariant { get; set; } = SortingVariants.Id;

        public static string GetUsername()
        {
            return Account.UserName;
        }

        public static void SetCurrentLanguage(string language)
        {
            CurrentLanguage = new Language() { Name = language };
        }

        public static Language GetCurrentLanguage()
        {
            return CurrentLanguage;
        }

        public static async Task<bool> Login(string email, string password)
        {
            Account = await AccountManager.Login(email, password);
            return Account == null ? false : true;
        }

        public static async Task<bool> Register(string email, string password, string nativeLanguage)
        {
            Account = await AccountManager.Register(email, password, nativeLanguage);
            return Account == null ? false : true;
        }

        public static async Task<List<Language>> GetLanguages()
        {
            return await Account.GetLanguages();
        }

        public static async Task AddLanguage(string languageName)
        {
            await Account.AddLanguage(languageName);
        }

        public static async Task<List<WordPriority>> GetWordPriorities(int amount, int offset, string language)
        {
            return await Account.GetWordsPriorities(amount, offset, language, SortingVariant);
        }

        public static async Task AddWordPriorities(List<WordPriority> wordPriorities)
        {
            await Account.AddWordsPriorities(wordPriorities);
        }

        public static async Task UpdateWordsPriorities(List<WordPriority> wordPriorities)
        {
            await Account.UpdateWordsPriorities(wordPriorities);
        }

        public static async Task<int> GetWordPrioritiesCount()
        {
            return await Account.GetWordPrioritiesCount(CurrentLanguage.Name);
        }

        public static async Task<List<WordPriority>> GetTranslations(string word)
        {
            return await Account.GetTranslations(GetCurrentLanguage().Name, word);
        }

        public static async Task<List<WordPriority>> GenerateQuiz()
        {
            return await Account.GenerateQuiz(CurrentLanguage.Name);
        }

        public static async Task<bool> ForeignWordExists(string word)
        {
            return await Account.ForeignWordExists(CurrentLanguage.Name, word);
        }

        public static async Task DeleteWord(string foreignWord)
        {
             await Account.DeleteWord(CurrentLanguage.Name, foreignWord);
        }

        public static async Task RenameWord(string originalWord, string newWord)
        {
            await Account.RenameWord(CurrentLanguage.Name, originalWord, newWord);
        }

        public static void SetSortingVariant(SortingVariants sortingVariant)
        {
            SortingVariant = sortingVariant;
        }

        public static async Task SubmitQuiz(List<WordPriority> wordPriorities)
        {
            await Account.SubmitQuiz(wordPriorities);
        }
    }
}

using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System;
using System.Text;
using System.Collections.Generic;


namespace AccountTransactions
{
    public enum SortingVariants { Id, NativePhrase, Priority, ForeignWord }

    public static class AccountManager
    {
        private static readonly string url = "http://77.47.208.42:5000/JSONData/";
        private static HttpClient httpClient;
        static AccountManager()
        {
            httpClient = new HttpClient();
        }
        
        public static async Task<Account> Login(string email, string password)
        {
            Account account;
            string jsondata = JsonConvert.SerializeObject(new {Email = email, Password = password});
            try{
                HttpResponseMessage hrm = await httpClient.PostAsync(url + "Login",new StringContent(jsondata,Encoding.UTF8,"application/json"));
                hrm.EnsureSuccessStatusCode();
                string response = await hrm.Content.ReadAsStringAsync();
                SignInResponse signinresponse = JsonConvert.DeserializeObject<SignInResponse>(response);
                account = new Account(email, signinresponse.Token);
                return account;
                
            } catch(Exception e){
                return null;
            }

        }

        public static async Task<Account> Register(string email, string password, string nativeLanguage)
        {
            Account account;
             try{
                 HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, url + "Register");
                 var content = JsonConvert.SerializeObject(new { Email = email, Password = password, NativeLanguage = nativeLanguage });
                 requestMessage.Content = new StringContent(content, Encoding.UTF8, "application/json");
                 HttpResponseMessage hrm = await httpClient.SendAsync(requestMessage);
                 hrm.EnsureSuccessStatusCode();
                 string response = await hrm.Content.ReadAsStringAsync();
                 SignInResponse registerResponse = JsonConvert.DeserializeObject<SignInResponse>(response);
                 account = new Account(email, registerResponse.Token);
                 return account;
                 
             } catch(Exception e){
                 return null;
             }

        }

        public static async Task<List<WordPriority>> GetTranslations(this Account account, string language, string word)
        {
            try{
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post,url +"GetTranslations");
                request.Headers.Add("Authorization","Bearer " + account.Token);
                var content =  JsonConvert.SerializeObject(new {Language = language, Word = word});
                request.Content = new StringContent(content,Encoding.UTF8,"application/json");             
                HttpResponseMessage hrm = await httpClient.SendAsync(request);
                hrm.EnsureSuccessStatusCode();
                string response = await hrm.Content.ReadAsStringAsync();
                List<WordPriority> phrases = JsonConvert.DeserializeObject<List<WordPriority>>(response);
                return phrases;

            } catch(Exception e){
                return new List<WordPriority>();
            }
        }

        public static async Task<List<WordPriority>> GetWordsPriorities(this Account account, int amount, int offset, string language, SortingVariants sortingVariant = SortingVariants.Id)
        {
            try{
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url + "GetWordsPriorities");
                request.Headers.Add("Authorization","Bearer " + account.Token);
                var content =  JsonConvert.SerializeObject(new WordsPrioritiesPostModel() {Amount = amount, language = language, Offset = offset, SortingVariant = sortingVariant });
                request.Content = new StringContent(content,Encoding.UTF8,"application/json");             
                HttpResponseMessage hrm = await httpClient.SendAsync(request);
                hrm.EnsureSuccessStatusCode();
                string response = await hrm.Content.ReadAsStringAsync();
                List<WordPriority> phrases = JsonConvert.DeserializeObject<List<WordPriority>>(response);
                return phrases;

            } catch(Exception e){
                return new List<WordPriority>();
            }
        }

        public static async Task AddWordsPriorities(this Account account, List<WordPriority> wordPriorities)
        {
            try
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url + "AddWordsPriorities");
                request.Headers.Add("Authorization", "Bearer " + account.Token);
                var content = JsonConvert.SerializeObject(wordPriorities);
                request.Content = new StringContent(content, Encoding.UTF8, "application/json");
                HttpResponseMessage hrm = await httpClient.SendAsync(request);
                hrm.EnsureSuccessStatusCode();
            
            }
            catch (Exception e)
            {
            
            }
        }


        public static async Task UpdateWordsPriorities(this Account account, List<WordPriority> wordPriorities)
        {
            try
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url + "UpdateWordsPriorities");
                request.Headers.Add("Authorization", "Bearer " + account.Token);
                var content = JsonConvert.SerializeObject(wordPriorities);
                request.Content = new StringContent(content, Encoding.UTF8, "application/json");
                HttpResponseMessage hrm = await httpClient.SendAsync(request);
                hrm.EnsureSuccessStatusCode();

            }
            catch (Exception e)
            {

            }
        }

        public static async Task AddLanguage(this Account account, string languageName)
        {
            try{
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url + "AddLanguage");
                request.Headers.Add("Authorization","Bearer " + account.Token);
                var content = JsonConvert.SerializeObject(new {Name = languageName});
                request.Content = new StringContent(content,Encoding.UTF8,"application/json");             
                HttpResponseMessage hrm = await httpClient.SendAsync(request);
                hrm.EnsureSuccessStatusCode();
                return;

            } catch(Exception e){
                return;
            }
        }

        public static async Task<List<Language>> GetLanguages(this Account account)
        {
            try
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url + "GetLanguages");
                request.Headers.Add("Authorization", "Bearer " + account.Token);
                HttpResponseMessage hrm = await httpClient.SendAsync(request);
                hrm.EnsureSuccessStatusCode();
                List<Language> languages = JsonConvert.DeserializeObject<List<Language>>(await hrm.Content.ReadAsStringAsync());

                return languages;

            }
            catch (Exception e)
            {
                return new List<Language>();
            }
        }

        public static async Task<int> GetWordPrioritiesCount(this Account account, string language)
        {
            try
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url + "GetWordPrioritiesCount");
                var content = JsonConvert.SerializeObject(new {Name = language });
                request.Headers.Add("Authorization", "Bearer " + account.Token);
                request.Content = new StringContent(content,Encoding.UTF8,"application/json");
                HttpResponseMessage hrm = await httpClient.SendAsync(request);
                hrm.EnsureSuccessStatusCode();
                return JsonConvert.DeserializeObject<int>(await hrm.Content.ReadAsStringAsync());
                

            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static async Task<List<WordPriority>> GenerateQuiz(this Account account, string language)
        {
            try
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url + "GenerateQuiz");
                var content = JsonConvert.SerializeObject(new { Name = language });
                request.Headers.Add("Authorization", "Bearer " + account.Token);
                request.Content = new StringContent(content, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                List<WordPriority> wordPriorities = JsonConvert.DeserializeObject<List<WordPriority>>(await response.Content.ReadAsStringAsync());
                return wordPriorities;
            }
            catch (Exception e)
            {
                return new List<WordPriority>();
            }
        }

        public static async Task SubmitQuiz(this Account account, List<WordPriority> wordPriorities)
        {
            try
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url + "SubmitQuiz");
                var content = JsonConvert.SerializeObject(wordPriorities);
                request.Headers.Add("Authorization", "Bearer " + account.Token);
                request.Content = new StringContent(content, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                
            }
        }

        public static async Task<bool> ForeignWordExists(this Account account, string language, string word)
        {
            try
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url + "ForeignWordExists");
                request.Headers.Add("Authorization", "Bearer " + account.Token);
                var content = JsonConvert.SerializeObject(new {ForeignWord = word, Language = language});
                request.Content = new StringContent(content, Encoding.UTF8, "application/json");
                HttpResponseMessage hrm = await httpClient.SendAsync(request);
                hrm.EnsureSuccessStatusCode();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static async Task DeleteWord(this Account account, string language, string word)
        {
           try
           {
               HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url + "DeleteWord");
               request.Headers.Add("Authorization", "Bearer " + account.Token);
               var content = JsonConvert.SerializeObject(new { Language = language, ForeignWord = word });
               request.Content = new StringContent(content, Encoding.UTF8, "application/json");
               HttpResponseMessage hrm = await httpClient.SendAsync(request);
               hrm.EnsureSuccessStatusCode();

           }
           catch (Exception e)
           {
               
           }
        }

        public static async Task RenameWord(this Account account, string language, string originalWord, string newWord)
        {
           try
           {
               HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url + "RenameWord");
               request.Headers.Add("Authorization", "Bearer " + account.Token);
               var content = JsonConvert.SerializeObject(new { Language = language, OriginalWord = originalWord, NewWord = newWord});
               request.Content = new StringContent(content, Encoding.UTF8, "application/json");
               HttpResponseMessage hrm = await httpClient.SendAsync(request);
               hrm.EnsureSuccessStatusCode();

           }
           catch (Exception e)
           {

           }
        }

    }
}
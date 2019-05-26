namespace AdvDictionaryClientWindows
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNativePhraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byPriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byForeignWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxLanguages = new System.Windows.Forms.ListBox();
            this.buttonAddLanguage = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.dataGridViewWordPriorities = new System.Windows.Forms.DataGridView();
            this.NativePhrase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForeignWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddWordPriority = new System.Windows.Forms.Button();
            this.textBoxLanguage = new System.Windows.Forms.TextBox();
            this.labelPage = new System.Windows.Forms.Label();
            this.buttonDeleteWord = new System.Windows.Forms.Button();
            this.textBoxDeleteWord = new System.Windows.Forms.TextBox();
            this.labelDeleteWord = new System.Windows.Forms.Label();
            this.labelRename = new System.Windows.Forms.Label();
            this.textBoxOriginalWord = new System.Windows.Forms.TextBox();
            this.labelRenameTo = new System.Windows.Forms.Label();
            this.textBoxNewWord = new System.Windows.Forms.TextBox();
            this.buttonRenameWord = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWordPriorities)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.quizToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1114, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.byNativePhraseToolStripMenuItem,
            this.byPriorityToolStripMenuItem,
            this.byForeignWordToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // byNativePhraseToolStripMenuItem
            // 
            this.byNativePhraseToolStripMenuItem.Name = "byNativePhraseToolStripMenuItem";
            this.byNativePhraseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byNativePhraseToolStripMenuItem.Text = "By Native Phrase";
            this.byNativePhraseToolStripMenuItem.Click += new System.EventHandler(this.byNativePhraseToolStripMenuItem_Click);
            // 
            // byPriorityToolStripMenuItem
            // 
            this.byPriorityToolStripMenuItem.Name = "byPriorityToolStripMenuItem";
            this.byPriorityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byPriorityToolStripMenuItem.Text = "By priority";
            this.byPriorityToolStripMenuItem.Click += new System.EventHandler(this.byPriorityToolStripMenuItem_Click);
            // 
            // byForeignWordToolStripMenuItem
            // 
            this.byForeignWordToolStripMenuItem.Name = "byForeignWordToolStripMenuItem";
            this.byForeignWordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byForeignWordToolStripMenuItem.Text = "By Foreign Word";
            this.byForeignWordToolStripMenuItem.Click += new System.EventHandler(this.byForeignWordToolStripMenuItem_Click);
            // 
            // quizToolStripMenuItem
            // 
            this.quizToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem});
            this.quizToolStripMenuItem.Name = "quizToolStripMenuItem";
            this.quizToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.quizToolStripMenuItem.Text = "Quiz";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(479, 42);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(64, 24);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Hello, ";
            // 
            // listBoxLanguages
            // 
            this.listBoxLanguages.FormattingEnabled = true;
            this.listBoxLanguages.Location = new System.Drawing.Point(12, 205);
            this.listBoxLanguages.Name = "listBoxLanguages";
            this.listBoxLanguages.Size = new System.Drawing.Size(90, 342);
            this.listBoxLanguages.TabIndex = 2;
            this.listBoxLanguages.SelectedIndexChanged += new System.EventHandler(this.listBoxLanguages_SelectedIndexChanged);
            // 
            // buttonAddLanguage
            // 
            this.buttonAddLanguage.Location = new System.Drawing.Point(12, 121);
            this.buttonAddLanguage.Name = "buttonAddLanguage";
            this.buttonAddLanguage.Size = new System.Drawing.Size(90, 23);
            this.buttonAddLanguage.TabIndex = 3;
            this.buttonAddLanguage.Text = "Add Language";
            this.buttonAddLanguage.UseVisualStyleBackColor = true;
            this.buttonAddLanguage.Click += new System.EventHandler(this.buttonAddLanguage_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(227, 150);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(90, 23);
            this.buttonPrev.TabIndex = 4;
            this.buttonPrev.Text = "<<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(817, 147);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(90, 23);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // dataGridViewWordPriorities
            // 
            this.dataGridViewWordPriorities.AllowUserToAddRows = false;
            this.dataGridViewWordPriorities.AllowUserToDeleteRows = false;
            this.dataGridViewWordPriorities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWordPriorities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NativePhrase,
            this.Priority,
            this.ForeignWord});
            this.dataGridViewWordPriorities.Location = new System.Drawing.Point(227, 173);
            this.dataGridViewWordPriorities.Name = "dataGridViewWordPriorities";
            this.dataGridViewWordPriorities.ReadOnly = true;
            this.dataGridViewWordPriorities.Size = new System.Drawing.Size(680, 372);
            this.dataGridViewWordPriorities.TabIndex = 12;
            this.dataGridViewWordPriorities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWordPriorities_CellContentClick);
            // 
            // NativePhrase
            // 
            this.NativePhrase.HeaderText = "NativePhrase";
            this.NativePhrase.Name = "NativePhrase";
            this.NativePhrase.ReadOnly = true;
            this.NativePhrase.Width = 280;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            this.Priority.Width = 75;
            // 
            // ForeignWord
            // 
            this.ForeignWord.HeaderText = "ForeignWord";
            this.ForeignWord.Name = "ForeignWord";
            this.ForeignWord.ReadOnly = true;
            this.ForeignWord.Width = 280;
            // 
            // buttonAddWordPriority
            // 
            this.buttonAddWordPriority.Location = new System.Drawing.Point(439, 109);
            this.buttonAddWordPriority.Name = "buttonAddWordPriority";
            this.buttonAddWordPriority.Size = new System.Drawing.Size(235, 23);
            this.buttonAddWordPriority.TabIndex = 13;
            this.buttonAddWordPriority.Text = "Add new word";
            this.buttonAddWordPriority.UseVisualStyleBackColor = true;
            this.buttonAddWordPriority.Click += new System.EventHandler(this.buttonAddWordPriority_Click);
            // 
            // textBoxLanguage
            // 
            this.textBoxLanguage.Location = new System.Drawing.Point(12, 150);
            this.textBoxLanguage.Name = "textBoxLanguage";
            this.textBoxLanguage.Size = new System.Drawing.Size(90, 20);
            this.textBoxLanguage.TabIndex = 14;
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPage.Location = new System.Drawing.Point(548, 153);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(31, 20);
            this.labelPage.TabIndex = 15;
            this.labelPage.Text = "0/0";
            // 
            // buttonDeleteWord
            // 
            this.buttonDeleteWord.Location = new System.Drawing.Point(927, 260);
            this.buttonDeleteWord.Name = "buttonDeleteWord";
            this.buttonDeleteWord.Size = new System.Drawing.Size(175, 23);
            this.buttonDeleteWord.TabIndex = 16;
            this.buttonDeleteWord.Text = "Delete Word";
            this.buttonDeleteWord.UseVisualStyleBackColor = true;
            this.buttonDeleteWord.Click += new System.EventHandler(this.buttonDeleteWord_Click);
            // 
            // textBoxDeleteWord
            // 
            this.textBoxDeleteWord.Location = new System.Drawing.Point(927, 234);
            this.textBoxDeleteWord.Name = "textBoxDeleteWord";
            this.textBoxDeleteWord.Size = new System.Drawing.Size(175, 20);
            this.textBoxDeleteWord.TabIndex = 17;
            // 
            // labelDeleteWord
            // 
            this.labelDeleteWord.AutoSize = true;
            this.labelDeleteWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeleteWord.Location = new System.Drawing.Point(966, 205);
            this.labelDeleteWord.Name = "labelDeleteWord";
            this.labelDeleteWord.Size = new System.Drawing.Size(84, 16);
            this.labelDeleteWord.TabIndex = 18;
            this.labelDeleteWord.Text = "Delete Word";
            // 
            // labelRename
            // 
            this.labelRename.AutoSize = true;
            this.labelRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRename.Location = new System.Drawing.Point(980, 349);
            this.labelRename.Name = "labelRename";
            this.labelRename.Size = new System.Drawing.Size(60, 16);
            this.labelRename.TabIndex = 19;
            this.labelRename.Text = "Rename";
            // 
            // textBoxOriginalWord
            // 
            this.textBoxOriginalWord.Location = new System.Drawing.Point(927, 368);
            this.textBoxOriginalWord.Name = "textBoxOriginalWord";
            this.textBoxOriginalWord.Size = new System.Drawing.Size(175, 20);
            this.textBoxOriginalWord.TabIndex = 20;
            // 
            // labelRenameTo
            // 
            this.labelRenameTo.AutoSize = true;
            this.labelRenameTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRenameTo.Location = new System.Drawing.Point(1001, 391);
            this.labelRenameTo.Name = "labelRenameTo";
            this.labelRenameTo.Size = new System.Drawing.Size(25, 16);
            this.labelRenameTo.TabIndex = 21;
            this.labelRenameTo.Text = "To";
            // 
            // textBoxNewWord
            // 
            this.textBoxNewWord.Location = new System.Drawing.Point(927, 410);
            this.textBoxNewWord.Name = "textBoxNewWord";
            this.textBoxNewWord.Size = new System.Drawing.Size(175, 20);
            this.textBoxNewWord.TabIndex = 22;
            // 
            // buttonRenameWord
            // 
            this.buttonRenameWord.Location = new System.Drawing.Point(927, 436);
            this.buttonRenameWord.Name = "buttonRenameWord";
            this.buttonRenameWord.Size = new System.Drawing.Size(175, 23);
            this.buttonRenameWord.TabIndex = 23;
            this.buttonRenameWord.Text = "Rename Word";
            this.buttonRenameWord.UseVisualStyleBackColor = true;
            this.buttonRenameWord.Click += new System.EventHandler(this.buttonRenameWord_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 611);
            this.Controls.Add(this.buttonRenameWord);
            this.Controls.Add(this.textBoxNewWord);
            this.Controls.Add(this.labelRenameTo);
            this.Controls.Add(this.textBoxOriginalWord);
            this.Controls.Add(this.labelRename);
            this.Controls.Add(this.labelDeleteWord);
            this.Controls.Add(this.textBoxDeleteWord);
            this.Controls.Add(this.buttonDeleteWord);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.textBoxLanguage);
            this.Controls.Add(this.buttonAddWordPriority);
            this.Controls.Add(this.dataGridViewWordPriorities);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonAddLanguage);
            this.Controls.Add(this.listBoxLanguages);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1130, 650);
            this.MinimumSize = new System.Drawing.Size(1130, 650);
            this.Name = "MainForm";
            this.Text = "AdvDictionary";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWordPriorities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizToolStripMenuItem;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox listBoxLanguages;
        private System.Windows.Forms.Button buttonAddLanguage;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.DataGridView dataGridViewWordPriorities;
        private System.Windows.Forms.DataGridViewTextBoxColumn NativePhrase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForeignWord;
        private System.Windows.Forms.Button buttonAddWordPriority;
        private System.Windows.Forms.TextBox textBoxLanguage;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.Button buttonDeleteWord;
        private System.Windows.Forms.TextBox textBoxDeleteWord;
        private System.Windows.Forms.Label labelDeleteWord;
        private System.Windows.Forms.Label labelRename;
        private System.Windows.Forms.TextBox textBoxOriginalWord;
        private System.Windows.Forms.Label labelRenameTo;
        private System.Windows.Forms.TextBox textBoxNewWord;
        private System.Windows.Forms.Button buttonRenameWord;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNativePhraseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byPriorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byForeignWordToolStripMenuItem;
    }
}


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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWordPriorities)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.quizToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.startToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(548, 43);
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
            this.listBoxLanguages.Size = new System.Drawing.Size(90, 394);
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
            this.buttonPrev.Location = new System.Drawing.Point(381, 147);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(90, 23);
            this.buttonPrev.TabIndex = 4;
            this.buttonPrev.Text = "<<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(971, 147);
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
            this.dataGridViewWordPriorities.Location = new System.Drawing.Point(381, 176);
            this.dataGridViewWordPriorities.Name = "dataGridViewWordPriorities";
            this.dataGridViewWordPriorities.ReadOnly = true;
            this.dataGridViewWordPriorities.Size = new System.Drawing.Size(680, 394);
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
            this.buttonAddWordPriority.Location = new System.Drawing.Point(612, 112);
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
            this.labelPage.Location = new System.Drawing.Point(719, 150);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(31, 20);
            this.labelPage.TabIndex = 15;
            this.labelPage.Text = "0/0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
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
    }
}


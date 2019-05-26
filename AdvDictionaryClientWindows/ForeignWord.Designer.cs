namespace AdvDictionaryClientWindows
{
    partial class ForeignWord
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
            this.listBoxNativePhrases = new System.Windows.Forms.ListBox();
            this.textBoxForeignWord = new System.Windows.Forms.TextBox();
            this.textBoxNativePhrase = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.buttonNativePhrase = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonChangePriority = new System.Windows.Forms.Button();
            this.buttonRemovePhrase = new System.Windows.Forms.Button();
            this.labelForeignWord = new System.Windows.Forms.Label();
            this.buttonAddForeignWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentForeignWord = new System.Windows.Forms.Label();
            this.textBoxPriority = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxNativePhrases
            // 
            this.listBoxNativePhrases.FormattingEnabled = true;
            this.listBoxNativePhrases.Location = new System.Drawing.Point(12, 189);
            this.listBoxNativePhrases.Name = "listBoxNativePhrases";
            this.listBoxNativePhrases.Size = new System.Drawing.Size(121, 199);
            this.listBoxNativePhrases.TabIndex = 0;
            this.listBoxNativePhrases.SelectedIndexChanged += new System.EventHandler(this.listBoxNativePhrases_SelectedIndexChanged);
            // 
            // textBoxForeignWord
            // 
            this.textBoxForeignWord.Location = new System.Drawing.Point(546, 163);
            this.textBoxForeignWord.Name = "textBoxForeignWord";
            this.textBoxForeignWord.Size = new System.Drawing.Size(139, 20);
            this.textBoxForeignWord.TabIndex = 1;
            // 
            // textBoxNativePhrase
            // 
            this.textBoxNativePhrase.Location = new System.Drawing.Point(12, 87);
            this.textBoxNativePhrase.Name = "textBoxNativePhrase";
            this.textBoxNativePhrase.Size = new System.Drawing.Size(121, 20);
            this.textBoxNativePhrase.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(270, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(248, 29);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Add new foreign word";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriority.Location = new System.Drawing.Point(257, 245);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(128, 18);
            this.labelPriority.TabIndex = 4;
            this.labelPriority.Text = "Current Priority - 0";
            // 
            // buttonNativePhrase
            // 
            this.buttonNativePhrase.Location = new System.Drawing.Point(12, 113);
            this.buttonNativePhrase.Name = "buttonNativePhrase";
            this.buttonNativePhrase.Size = new System.Drawing.Size(121, 32);
            this.buttonNativePhrase.TabIndex = 6;
            this.buttonNativePhrase.Text = "Add Phrase";
            this.buttonNativePhrase.UseVisualStyleBackColor = true;
            this.buttonNativePhrase.Click += new System.EventHandler(this.buttonNativePhrase_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(629, 415);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(121, 32);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 415);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 32);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonChangePriority
            // 
            this.buttonChangePriority.Location = new System.Drawing.Point(290, 157);
            this.buttonChangePriority.Name = "buttonChangePriority";
            this.buttonChangePriority.Size = new System.Drawing.Size(100, 26);
            this.buttonChangePriority.TabIndex = 9;
            this.buttonChangePriority.Text = "Change Priority";
            this.buttonChangePriority.UseVisualStyleBackColor = true;
            this.buttonChangePriority.Click += new System.EventHandler(this.buttonChangePriority_Click);
            // 
            // buttonRemovePhrase
            // 
            this.buttonRemovePhrase.Location = new System.Drawing.Point(12, 151);
            this.buttonRemovePhrase.Name = "buttonRemovePhrase";
            this.buttonRemovePhrase.Size = new System.Drawing.Size(121, 32);
            this.buttonRemovePhrase.TabIndex = 12;
            this.buttonRemovePhrase.Text = "Remove Phrase";
            this.buttonRemovePhrase.UseVisualStyleBackColor = true;
            this.buttonRemovePhrase.Click += new System.EventHandler(this.buttonRemovePhrase_Click);
            // 
            // labelForeignWord
            // 
            this.labelForeignWord.AutoSize = true;
            this.labelForeignWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForeignWord.Location = new System.Drawing.Point(549, 127);
            this.labelForeignWord.Name = "labelForeignWord";
            this.labelForeignWord.Size = new System.Drawing.Size(142, 18);
            this.labelForeignWord.TabIndex = 13;
            this.labelForeignWord.Text = "Specify foreign word";
            // 
            // buttonAddForeignWord
            // 
            this.buttonAddForeignWord.Location = new System.Drawing.Point(546, 207);
            this.buttonAddForeignWord.Name = "buttonAddForeignWord";
            this.buttonAddForeignWord.Size = new System.Drawing.Size(139, 26);
            this.buttonAddForeignWord.TabIndex = 14;
            this.buttonAddForeignWord.Text = "AddForeignWord";
            this.buttonAddForeignWord.UseVisualStyleBackColor = true;
            this.buttonAddForeignWord.Click += new System.EventHandler(this.buttonAddForeignWord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Specify native phrase";
            // 
            // labelCurrentForeignWord
            // 
            this.labelCurrentForeignWord.AutoSize = true;
            this.labelCurrentForeignWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentForeignWord.Location = new System.Drawing.Point(480, 247);
            this.labelCurrentForeignWord.Name = "labelCurrentForeignWord";
            this.labelCurrentForeignWord.Size = new System.Drawing.Size(136, 16);
            this.labelCurrentForeignWord.TabIndex = 16;
            this.labelCurrentForeignWord.Text = "Current foreign word - ";
            // 
            // textBoxPriority
            // 
            this.textBoxPriority.Location = new System.Drawing.Point(251, 163);
            this.textBoxPriority.Name = "textBoxPriority";
            this.textBoxPriority.Size = new System.Drawing.Size(33, 20);
            this.textBoxPriority.TabIndex = 17;
            this.textBoxPriority.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPriority_KeyPress);
            // 
            // ForeignWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 457);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxPriority);
            this.Controls.Add(this.labelCurrentForeignWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddForeignWord);
            this.Controls.Add(this.labelForeignWord);
            this.Controls.Add(this.buttonRemovePhrase);
            this.Controls.Add(this.buttonChangePriority);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonNativePhrase);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxNativePhrase);
            this.Controls.Add(this.textBoxForeignWord);
            this.Controls.Add(this.listBoxNativePhrases);
            this.Name = "ForeignWord";
            this.Text = "Foreign word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNativePhrases;
        private System.Windows.Forms.TextBox textBoxForeignWord;
        private System.Windows.Forms.TextBox textBoxNativePhrase;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Button buttonNativePhrase;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonChangePriority;
        private System.Windows.Forms.Button buttonRemovePhrase;
        private System.Windows.Forms.Label labelForeignWord;
        private System.Windows.Forms.Button buttonAddForeignWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrentForeignWord;
        private System.Windows.Forms.TextBox textBoxPriority;
    }
}
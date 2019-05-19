namespace AdvDictionaryClientWindows
{
    partial class Quiz
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
            this.buttonPrev = new System.Windows.Forms.Button();
            this.labelWordCount = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelNativePhrase = new System.Windows.Forms.Label();
            this.labelEnterWord = new System.Windows.Forms.Label();
            this.textBoxForeignWord = new System.Windows.Forms.TextBox();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSetForeignWord = new System.Windows.Forms.Button();
            this.labelCurrentAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(35, 29);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(157, 23);
            this.buttonPrev.TabIndex = 5;
            this.buttonPrev.Text = "<<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // labelWordCount
            // 
            this.labelWordCount.AutoSize = true;
            this.labelWordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWordCount.Location = new System.Drawing.Point(359, 29);
            this.labelWordCount.Name = "labelWordCount";
            this.labelWordCount.Size = new System.Drawing.Size(31, 20);
            this.labelWordCount.TabIndex = 16;
            this.labelWordCount.Text = "0/0";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(570, 34);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(174, 23);
            this.buttonNext.TabIndex = 17;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelNativePhrase
            // 
            this.labelNativePhrase.AutoSize = true;
            this.labelNativePhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNativePhrase.Location = new System.Drawing.Point(306, 103);
            this.labelNativePhrase.Name = "labelNativePhrase";
            this.labelNativePhrase.Size = new System.Drawing.Size(141, 25);
            this.labelNativePhrase.TabIndex = 18;
            this.labelNativePhrase.Text = "NativePhrase";
            // 
            // labelEnterWord
            // 
            this.labelEnterWord.AutoSize = true;
            this.labelEnterWord.Location = new System.Drawing.Point(203, 201);
            this.labelEnterWord.Name = "labelEnterWord";
            this.labelEnterWord.Size = new System.Drawing.Size(71, 13);
            this.labelEnterWord.TabIndex = 19;
            this.labelEnterWord.Text = "Foreign word:";
            // 
            // textBoxForeignWord
            // 
            this.textBoxForeignWord.Location = new System.Drawing.Point(280, 198);
            this.textBoxForeignWord.Name = "textBoxForeignWord";
            this.textBoxForeignWord.Size = new System.Drawing.Size(167, 20);
            this.textBoxForeignWord.TabIndex = 20;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(661, 352);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(96, 24);
            this.buttonFinish.TabIndex = 21;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(35, 353);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 22;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSetForeignWord
            // 
            this.buttonSetForeignWord.Location = new System.Drawing.Point(453, 198);
            this.buttonSetForeignWord.Name = "buttonSetForeignWord";
            this.buttonSetForeignWord.Size = new System.Drawing.Size(137, 20);
            this.buttonSetForeignWord.TabIndex = 23;
            this.buttonSetForeignWord.Text = "Set foreign word";
            this.buttonSetForeignWord.UseVisualStyleBackColor = true;
            this.buttonSetForeignWord.Click += new System.EventHandler(this.buttonSetForeignWord_Click);
            // 
            // labelCurrentAnswer
            // 
            this.labelCurrentAnswer.AutoSize = true;
            this.labelCurrentAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentAnswer.Location = new System.Drawing.Point(264, 247);
            this.labelCurrentAnswer.Name = "labelCurrentAnswer";
            this.labelCurrentAnswer.Size = new System.Drawing.Size(126, 20);
            this.labelCurrentAnswer.TabIndex = 24;
            this.labelCurrentAnswer.Text = "Current answer -";
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 400);
            this.Controls.Add(this.labelCurrentAnswer);
            this.Controls.Add(this.buttonSetForeignWord);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.textBoxForeignWord);
            this.Controls.Add(this.labelEnterWord);
            this.Controls.Add(this.labelNativePhrase);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelWordCount);
            this.Controls.Add(this.buttonPrev);
            this.Name = "Quiz";
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Label labelWordCount;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelNativePhrase;
        private System.Windows.Forms.Label labelEnterWord;
        private System.Windows.Forms.TextBox textBoxForeignWord;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSetForeignWord;
        private System.Windows.Forms.Label labelCurrentAnswer;
    }
}
namespace Project_Dictionaries
{
    partial class AddTranslationForm
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
            this.LanguageBox = new System.Windows.Forms.ComboBox();
            this.TranslationBox = new System.Windows.Forms.TextBox();
            this.AddTranslationButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddLanguagesButton = new System.Windows.Forms.Button();
            this.DeleteLanguageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LanguageBox
            // 
            this.LanguageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageBox.Location = new System.Drawing.Point(12, 12);
            this.LanguageBox.Name = "LanguageBox";
            this.LanguageBox.Size = new System.Drawing.Size(374, 21);
            this.LanguageBox.TabIndex = 0;
            // 
            // TranslationBox
            // 
            this.TranslationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TranslationBox.Location = new System.Drawing.Point(12, 53);
            this.TranslationBox.Name = "TranslationBox";
            this.TranslationBox.Size = new System.Drawing.Size(374, 30);
            this.TranslationBox.TabIndex = 1;
            // 
            // AddTranslationButton
            // 
            this.AddTranslationButton.Location = new System.Drawing.Point(27, 101);
            this.AddTranslationButton.Name = "AddTranslationButton";
            this.AddTranslationButton.Size = new System.Drawing.Size(81, 66);
            this.AddTranslationButton.TabIndex = 2;
            this.AddTranslationButton.Text = "Добавить";
            this.AddTranslationButton.UseVisualStyleBackColor = true;
            this.AddTranslationButton.Click += new System.EventHandler(this.AddTranslationButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(288, 101);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(81, 66);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddLanguagesButton
            // 
            this.AddLanguagesButton.Location = new System.Drawing.Point(114, 101);
            this.AddLanguagesButton.Name = "AddLanguagesButton";
            this.AddLanguagesButton.Size = new System.Drawing.Size(81, 66);
            this.AddLanguagesButton.TabIndex = 4;
            this.AddLanguagesButton.Text = "Добавить язык";
            this.AddLanguagesButton.UseVisualStyleBackColor = true;
            this.AddLanguagesButton.Click += new System.EventHandler(this.AddLanguagesButton_Click);
            // 
            // DeleteLanguageButton
            // 
            this.DeleteLanguageButton.Location = new System.Drawing.Point(201, 101);
            this.DeleteLanguageButton.Name = "DeleteLanguageButton";
            this.DeleteLanguageButton.Size = new System.Drawing.Size(81, 66);
            this.DeleteLanguageButton.TabIndex = 5;
            this.DeleteLanguageButton.Text = "Удалить язык";
            this.DeleteLanguageButton.UseVisualStyleBackColor = true;
            this.DeleteLanguageButton.Click += new System.EventHandler(this.DeleteLanguageButton_Click);
            // 
            // AddTranslationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 179);
            this.Controls.Add(this.DeleteLanguageButton);
            this.Controls.Add(this.AddLanguagesButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddTranslationButton);
            this.Controls.Add(this.TranslationBox);
            this.Controls.Add(this.LanguageBox);
            this.Name = "AddTranslationForm";
            this.Text = "AddWordForm";
            this.Load += new System.EventHandler(this.AddTranslationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LanguageBox;
        private System.Windows.Forms.TextBox TranslationBox;
        private System.Windows.Forms.Button AddTranslationButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddLanguagesButton;
        private System.Windows.Forms.Button DeleteLanguageButton;
    }
}
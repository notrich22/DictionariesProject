namespace Project_Dictionaries
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.WordsBox = new System.Windows.Forms.ListBox();
            this.TranslationsBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddTranslationButton = new System.Windows.Forms.Button();
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.LanguagesCheckBox = new System.Windows.Forms.CheckedListBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteTranslationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WordsBox
            // 
            this.WordsBox.FormattingEnabled = true;
            this.WordsBox.Location = new System.Drawing.Point(12, 12);
            this.WordsBox.Name = "WordsBox";
            this.WordsBox.Size = new System.Drawing.Size(175, 251);
            this.WordsBox.TabIndex = 0;
            this.WordsBox.SelectedIndexChanged += new System.EventHandler(this.WordsBox_SelectedIndexChanged);
            // 
            // TranslationsBox
            // 
            this.TranslationsBox.FormattingEnabled = true;
            this.TranslationsBox.Location = new System.Drawing.Point(652, 12);
            this.TranslationsBox.Name = "TranslationsBox";
            this.TranslationsBox.Size = new System.Drawing.Size(175, 199);
            this.TranslationsBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 328);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(175, 54);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить слово";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 393);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(175, 54);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить слово";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddTranslationButton
            // 
            this.AddTranslationButton.Location = new System.Drawing.Point(652, 393);
            this.AddTranslationButton.Name = "AddTranslationButton";
            this.AddTranslationButton.Size = new System.Drawing.Size(175, 54);
            this.AddTranslationButton.TabIndex = 4;
            this.AddTranslationButton.Text = "Добавить перевод";
            this.AddTranslationButton.UseVisualStyleBackColor = true;
            this.AddTranslationButton.Click += new System.EventHandler(this.AddTranslationButton_Click);
            // 
            // WordTextBox
            // 
            this.WordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordTextBox.Location = new System.Drawing.Point(12, 277);
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.Size = new System.Drawing.Size(175, 38);
            this.WordTextBox.TabIndex = 5;
            // 
            // LanguagesCheckBox
            // 
            this.LanguagesCheckBox.CheckOnClick = true;
            this.LanguagesCheckBox.FormattingEnabled = true;
            this.LanguagesCheckBox.Location = new System.Drawing.Point(652, 221);
            this.LanguagesCheckBox.Name = "LanguagesCheckBox";
            this.LanguagesCheckBox.Size = new System.Drawing.Size(175, 94);
            this.LanguagesCheckBox.TabIndex = 7;
            this.LanguagesCheckBox.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(291, 393);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(265, 54);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Сохранить слова и переводы";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteTranslationButton
            // 
            this.DeleteTranslationButton.Location = new System.Drawing.Point(652, 328);
            this.DeleteTranslationButton.Name = "DeleteTranslationButton";
            this.DeleteTranslationButton.Size = new System.Drawing.Size(175, 54);
            this.DeleteTranslationButton.TabIndex = 9;
            this.DeleteTranslationButton.Text = "Удалить перевод";
            this.DeleteTranslationButton.UseVisualStyleBackColor = true;
            this.DeleteTranslationButton.Click += new System.EventHandler(this.DeleteTranslationButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(839, 459);
            this.Controls.Add(this.DeleteTranslationButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LanguagesCheckBox);
            this.Controls.Add(this.WordTextBox);
            this.Controls.Add(this.AddTranslationButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TranslationsBox);
            this.Controls.Add(this.WordsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionaries";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WordsBox;
        private System.Windows.Forms.ListBox TranslationsBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddTranslationButton;
        private System.Windows.Forms.TextBox WordTextBox;
        private System.Windows.Forms.CheckedListBox LanguagesCheckBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteTranslationButton;
    }
}


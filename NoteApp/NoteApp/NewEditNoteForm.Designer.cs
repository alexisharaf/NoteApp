namespace NoteApp
{
    partial class NewEditNoteForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.noteCategoryLabel = new System.Windows.Forms.Label();
            this.noteTextTextBox = new System.Windows.Forms.TextBox();
            this.modifiactionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.creationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NoteNameLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.noteTitleTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Location = new System.Drawing.Point(72, 554);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // noteCategoryLabel
            // 
            this.noteCategoryLabel.AutoSize = true;
            this.noteCategoryLabel.Location = new System.Drawing.Point(19, 142);
            this.noteCategoryLabel.Name = "noteCategoryLabel";
            this.noteCategoryLabel.Size = new System.Drawing.Size(60, 13);
            this.noteCategoryLabel.TabIndex = 17;
            this.noteCategoryLabel.Text = "Категория";
            // 
            // noteTextTextBox
            // 
            this.noteTextTextBox.Location = new System.Drawing.Point(21, 182);
            this.noteTextTextBox.Multiline = true;
            this.noteTextTextBox.Name = "noteTextTextBox";
            this.noteTextTextBox.Size = new System.Drawing.Size(578, 339);
            this.noteTextTextBox.TabIndex = 16;
            this.noteTextTextBox.Text = "Текст заметки";
            // 
            // modifiactionDateTimePicker
            // 
            this.modifiactionDateTimePicker.Location = new System.Drawing.Point(124, 110);
            this.modifiactionDateTimePicker.Name = "modifiactionDateTimePicker";
            this.modifiactionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.modifiactionDateTimePicker.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Дата изменения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Дата создания";
            // 
            // creationDateTimePicker
            // 
            this.creationDateTimePicker.Location = new System.Drawing.Point(124, 79);
            this.creationDateTimePicker.Name = "creationDateTimePicker";
            this.creationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.creationDateTimePicker.TabIndex = 12;
            // 
            // NoteNameLabel
            // 
            this.NoteNameLabel.AutoSize = true;
            this.NoteNameLabel.Location = new System.Drawing.Point(18, 42);
            this.NoteNameLabel.Name = "NoteNameLabel";
            this.NoteNameLabel.Size = new System.Drawing.Size(61, 13);
            this.NoteNameLabel.TabIndex = 11;
            this.NoteNameLabel.Text = "Заголовок";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(124, 139);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(475, 21);
            this.categoryComboBox.TabIndex = 18;
            // 
            // noteTitleTextBox
            // 
            this.noteTitleTextBox.Location = new System.Drawing.Point(124, 42);
            this.noteTitleTextBox.Name = "noteTitleTextBox";
            this.noteTitleTextBox.Size = new System.Drawing.Size(475, 20);
            this.noteTitleTextBox.TabIndex = 19;
            this.noteTitleTextBox.Text = "Название заметки";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(453, 554);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // NewEditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 600);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.noteTitleTextBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.noteCategoryLabel);
            this.Controls.Add(this.noteTextTextBox);
            this.Controls.Add(this.modifiactionDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.creationDateTimePicker);
            this.Controls.Add(this.NoteNameLabel);
            this.Controls.Add(this.SaveButton);
            this.Name = "NewEditNoteForm";
            this.Text = "NewEditNoteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label noteCategoryLabel;
        private System.Windows.Forms.TextBox noteTextTextBox;
        private System.Windows.Forms.DateTimePicker modifiactionDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker creationDateTimePicker;
        private System.Windows.Forms.Label NoteNameLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox noteTitleTextBox;
        private System.Windows.Forms.Button cancelButton;
    }
}
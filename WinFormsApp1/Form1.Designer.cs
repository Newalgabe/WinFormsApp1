namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NameTextBox = new TextBox();
            SurnameTextBox = new TextBox();
            AgeTextBox = new TextBox();
            PersonsListBox = new ListBox();
            DeletePersonButton = new Button();
            AddPersonButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(97, 9);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 3;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(97, 38);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(100, 23);
            SurnameTextBox.TabIndex = 4;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(97, 67);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(100, 23);
            AgeTextBox.TabIndex = 5;
            // 
            // PersonsListBox
            // 
            PersonsListBox.FormattingEnabled = true;
            PersonsListBox.ItemHeight = 15;
            PersonsListBox.Location = new Point(12, 118);
            PersonsListBox.Name = "PersonsListBox";
            PersonsListBox.Size = new Size(776, 229);
            PersonsListBox.TabIndex = 6;
            // 
            // DeletePersonButton
            // 
            DeletePersonButton.Location = new Point(666, 353);
            DeletePersonButton.Name = "DeletePersonButton";
            DeletePersonButton.Size = new Size(122, 30);
            DeletePersonButton.TabIndex = 7;
            DeletePersonButton.Text = "Delete person";
            DeletePersonButton.UseVisualStyleBackColor = true;
            DeletePersonButton.Click += DeletePersonButton_Click;
            // 
            // AddPersonButton
            // 
            AddPersonButton.Location = new Point(666, 82);
            AddPersonButton.Name = "AddPersonButton";
            AddPersonButton.Size = new Size(122, 30);
            AddPersonButton.TabIndex = 8;
            AddPersonButton.Text = "Add person";
            AddPersonButton.UseVisualStyleBackColor = true;
            AddPersonButton.Click += AddPersonButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddPersonButton);
            Controls.Add(DeletePersonButton);
            Controls.Add(PersonsListBox);
            Controls.Add(AgeTextBox);
            Controls.Add(SurnameTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NameTextBox;
        private TextBox SurnameTextBox;
        private TextBox AgeTextBox;
        private ListBox PersonsListBox;
        private Button DeletePersonButton;
        private Button AddPersonButton;
    }
}
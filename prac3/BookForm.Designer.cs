namespace prac3
{
    partial class BookForm
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
            label1 = new Label();
            AuthorTextBox = new TextBox();
            label2 = new Label();
            TitleTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            YearTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            CoverPictureBox = new PictureBox();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CoverPictureBox).BeginInit();
            SuspendLayout();
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(12, 27);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(468, 23);
            AuthorTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Название";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(12, 90);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(468, 23);
            TitleTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 4;
            label3.Text = "Год издания";
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(12, 157);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(468, 23);
            YearTextBox.TabIndex = 6;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(12, 223);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(468, 215);
            DescriptionTextBox.TabIndex = 7;
            // 
            // CoverPictureBox
            // 
            CoverPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CoverPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            CoverPictureBox.BorderStyle = BorderStyle.Fixed3D;
            CoverPictureBox.Location = new Point(486, 9);
            CoverPictureBox.Name = "CoverPictureBox";
            CoverPictureBox.Size = new Size(302, 395);
            CoverPictureBox.TabIndex = 8;
            CoverPictureBox.TabStop = false;
            CoverPictureBox.Click += CoverPictureBox_Click;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaveButton.Location = new Point(486, 410);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(302, 28);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += button1_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveButton);
            Controls.Add(CoverPictureBox);
            Controls.Add(DescriptionTextBox);
            Controls.Add(YearTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TitleTextBox);
            Controls.Add(label2);
            Controls.Add(AuthorTextBox);
            Controls.Add(label1);
            Name = "BookForm";
            Text = "Информация о книге";
            ((System.ComponentModel.ISupportInitialize)CoverPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox AuthorTextBox;
        private Label label2;
        private TextBox TitleTextBox;
        private Label label3;
        private Label label4;
        private TextBox YearTextBox;
        private TextBox DescriptionTextBox;
        private PictureBox CoverPictureBox;
        private Button SaveButton;
    }
}
namespace prac3
{
    partial class BookControll
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            CoverPictureBox = new PictureBox();
            TitleLabel = new Label();
            DescriptionLabel = new Label();
            EditButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CoverPictureBox).BeginInit();
            SuspendLayout();
            // 
            // CoverPictureBox
            // 
            CoverPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            CoverPictureBox.BorderStyle = BorderStyle.Fixed3D;
            CoverPictureBox.Location = new Point(3, 3);
            CoverPictureBox.Name = "CoverPictureBox";
            CoverPictureBox.Size = new Size(168, 226);
            CoverPictureBox.TabIndex = 0;
            CoverPictureBox.TabStop = false;
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TitleLabel.Location = new Point(196, 13);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(487, 32);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Автор. Название (год издания)";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DescriptionLabel.Location = new Point(196, 45);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(487, 184);
            DescriptionLabel.TabIndex = 2;
            DescriptionLabel.Text = "описание";
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditButton.Location = new Point(644, 13);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(39, 32);
            EditButton.TabIndex = 3;
            EditButton.Text = "✎";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // BookControll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(EditButton);
            Controls.Add(DescriptionLabel);
            Controls.Add(TitleLabel);
            Controls.Add(CoverPictureBox);
            Name = "BookControll";
            Size = new Size(686, 241);
            ((System.ComponentModel.ISupportInitialize)CoverPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox CoverPictureBox;
        private Label TitleLabel;
        private Label DescriptionLabel;
        private Button EditButton;
    }
}

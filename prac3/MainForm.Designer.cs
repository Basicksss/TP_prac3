namespace prac3
{
    partial class MainForm
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
            BookListTableLayout = new TableLayoutPanel();
            SuspendLayout();
            // 
            // BookListTableLayout
            // 
            BookListTableLayout.AutoScroll = true;
            BookListTableLayout.ColumnCount = 1;
            BookListTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            BookListTableLayout.Dock = DockStyle.Fill;
            BookListTableLayout.Location = new Point(0, 0);
            BookListTableLayout.Name = "BookListTableLayout";
            BookListTableLayout.RowCount = 1;
            BookListTableLayout.RowStyles.Add(new RowStyle());
            BookListTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            BookListTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            BookListTableLayout.Size = new Size(800, 780);
            BookListTableLayout.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 780);
            Controls.Add(BookListTableLayout);
            Name = "MainForm";
            Text = "Книги на легкое чтение";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel BookListTableLayout;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prac3
{
    public partial class BookControll : UserControl
    {
        Book currentBook;
        public BookControll(Book book)
        {
            InitializeComponent();

            currentBook = book;

            LoadBookDataToControls();
        }


        private void LoadBookDataToControls()
        {
            TitleLabel.Text = currentBook.Author + "." + currentBook.Title + " (" + currentBook.Year + ")";
            DescriptionLabel.Text = currentBook.Description;
            CoverPictureBox.BackgroundImage = currentBook.Cover;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            BookForm editBoolForm = new BookForm(currentBook);
            if(editBoolForm.ShowDialog() == DialogResult.OK)
            {
                LoadBookDataToControls();
            }
        }
    }
}

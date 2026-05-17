using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using static System.Reflection.Metadata.BlobBuilder;

namespace prac3
{
    public partial class MainForm : Form
    {
        Book[] books;
        public MainForm()
        {
            InitializeComponent();


            String jsonString = File.ReadAllText("bookList.txt");
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            books = JsonSerializer.Deserialize<Book[]>(jsonString, options);

            for (int i = 0; i < books.Length; i++)
            {
                BookControll control = new BookControll(books[i]);
                control.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                BookListTableLayout.Controls.Add(control);
                BookListTableLayout.SetRow(control, i);
            }
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            String jsonString = JsonSerializer.Serialize(books, options);
            File.WriteAllText("bookList.txt", jsonString);
        }
    }
}

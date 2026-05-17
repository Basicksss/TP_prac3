namespace prac3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Book[] books =
            {
                new Book()
                {
                    Author = "Сергей Лукьяненко",
                    Title = "Лабиринт отражений",
                    Year = 1997,
                    Description = "Действие романа одновременно происходит в реальном Питере"
                },
                new Book()
                {
                    Author = "Сергей Лукьяненко",
                    Title = "Лабиринт отражений",
                    Year = 1997,
                    Description = "Действие романа одновременно происходит в реальном Питере42424"
                },
                new Book()
                {
                    Author = "Сергей Лукьяненко",
                    Title = "Лабиринт отражений",
                    Year = 1997,
                    Description = "Действие романа одновременно происходит в реальном Питере42424424"
                }
            };

            for(int i=0;i<books.Length; i++)
            {
                BookControll control = new BookControll(books[i]);
                control.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                BookListTableLayout.Controls.Add(control);
                BookListTableLayout.SetRow(control, i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

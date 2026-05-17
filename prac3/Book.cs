using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace prac3
{
    public class Book
    {
        ///Имя автора
        public string Author { get; set; }
        ///Название книги
        public string Title { get; set; }
        ///Год издания
        public int Year { get; set; }
        ///Описание книги
        public string Description { get; set; }

        ///Картинка обложки
        [JsonIgnore]
        public Image Cover { get; set; }
    }
}

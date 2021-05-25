using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KropotovaExam1.Model
{
    public class LocalDataProvider : IDataProvider
    {
        public IEnumerable<Book> GetBooks()
        {
            return new Book[]{
            new Book{Type="Роман",Title="Война и мир", Year=1868, Weight= 1.84F, TimePublish =new DateTime(1868,4,21)},
            new Book{Type="Детектив",Title="Отцы и дети", Year=1861, Weight= 1.74F,TimePublish = new DateTime(1861,4,21)},
            new Book{Type="Рассказ",Title="Капитанская дочка", Year=1836, Weight= 4.84F, TimePublish = new DateTime(1836,4,21)} };
        }

        public IEnumerable<BookType> GetBookTypes()
        {
            return new BookType[] {
                new BookType { Title = "Роман" },
                new BookType { Title = "Детектив" },
                new BookType { Title = "Рассказ" },
            };
        }
    }
}
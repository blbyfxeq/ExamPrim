using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KropotovaExam1.Model
{
    interface IDataProvider
    {
        IEnumerable<Book> GetBooks();
        IEnumerable<BookType> GetBookTypes();
    }
}

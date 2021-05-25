using KropotovaExam1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KropotovaExam1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public string SelectedType = "";
        private IEnumerable<Book> _BookList = null;
        public IEnumerable<Book> BookList { 
            
            get 
            {
                return _BookList
            .Where(c => (SelectedType == "Все авторы" || c.Type == SelectedType));
            }
            set 
            {
                _BookList = value;
            } }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Globals.dataProvider = new LocalDataProvider();
            BookList = Globals.dataProvider.GetBooks();
        }
        public List<BookType> BookTypeList { get; set; }
    }

    internal interface INotifyPropertyChanged
    {

    }
}

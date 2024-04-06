using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KanBanWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Create a new card and add it to the column "Not Started"
        private void AddCardButton_Click(object sender, RoutedEventArgs e)
        {
            KanbanCard card = new KanbanCard();
            card.Title = "New Task";
            card.Description = "Description of the task";
            NotStartedColumn.Children.Add(card);
        }


    }
}
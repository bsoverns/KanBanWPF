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
            card.Tag = Guid.NewGuid();
            card.Title = "New Task";
            card.Description = "Description of the task";
            //card.IsActive = true;           
            NotStartedColumn.Children.Add(card);
        }

        private void Column_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(KanbanCard)) is KanbanCard card)
            {
                // Assuming the source is a Panel, you might need to remove the card from its current parent
                (card.Parent as Panel)?.Children.Remove(card);

                // Add the card to the target column
                StackPanel targetColumn = sender as StackPanel;
                targetColumn.Children.Add(card);

                // Optionally, perform actions based on the target column's name
                // For example:
                if (targetColumn.Name == "InProgressColumn")
                {
                    // Code to update the task status to "In Progress"
                }
            }
        }
    }
}
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

namespace KanBanWPF
{
    /// <summary>
    /// Interaction logic for KanbanCard.xaml
    /// </summary>
    public partial class KanbanCard : UserControl
    {
        private Point? dragStartPoint = null;

        public KanbanCard()
        {
            InitializeComponent();
        }

        //Add Tag property for unique identification
        public object Tag { get; set; }

        public string Title
        {
            get => TitleTextBlock.Text;
            set => TitleTextBlock.Text = value;
        }

        public string Description
        {
            get => DescriptionTextBlock.Text;
            set => DescriptionTextBlock.Text = value;
        }

        //public bool IsActive
        //{
        //    get => IsActiveBorder.Visibility == Visibility.Visible;
        //    set => IsActiveBorder.Visibility = value ? Visibility.Visible : Visibility.Collapsed;
        //}

        // You can add more properties for other elements

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Capture the start point
            dragStartPoint = e.GetPosition(this);
        }

        private void UserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && dragStartPoint.HasValue)
            {
                // Calculate the offset
                Point mousePos = e.GetPosition(this);
                Vector diff = dragStartPoint.Value - mousePos;

                if (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                    Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance)
                {
                    // Initialize the drag & drop operation
                    DragDrop.DoDragDrop(this, this, DragDropEffects.Move);
                    dragStartPoint = null; // Reset the start point
                }
            }
        }
    }

}

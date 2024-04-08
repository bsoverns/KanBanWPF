using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace KanBanWPF.Model
{
    class KanbanCard
    {
        public object Tag { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public User AssignedTo { get; private set; }
        public string CurrentColumn { get; private set; } 
        public DateTime ColumnEntryTime { get; private set; }        

        public KanbanCard(object tag, string title, string name, string description, User assignedTo, string initialColumn)
        {
            Tag = tag;
            Title = title;
            Description = description;
            AssignedTo = assignedTo;
            MoveToColumn(initialColumn); // Initialize the card in a column
        }

        // Method to move the card to a new column and reset the timer
        public void MoveToColumn(string newColumn)
        {
            CurrentColumn = newColumn;
            ColumnEntryTime = DateTime.Now; // Reset the timer to the current time
        }

        // Method to get the duration the card has been in the current column
        public TimeSpan GetTimeInCurrentColumn()
        {
            return DateTime.Now - ColumnEntryTime;
        }
    }
}
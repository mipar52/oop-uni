using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak02.Model
{
    public enum OperationType
    {
        Add,
        Update,
        Delete
    }

    public class ListOperationEventArgs: EventArgs
    {
        public OperationType Operation { get; set; }
        public object Value { get; set; }
        public DateTime Time { get; set; }
    }

    public delegate void ObservableListDelegate(object sender,  ListOperationEventArgs e);
}

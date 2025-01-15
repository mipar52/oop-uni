using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak02.Model
{
    public class ObservableList: ArrayList
    {
        public event ObservableListDelegate OnOperation;

        public override int Add(object value)
        {
            int index = base.Add(value);
            OnOperation?.Invoke(this, new ListOperationEventArgs
            {
                Operation = OperationType.Add,
                Value = value,
                Time = DateTime.Now,
            });
            return index;
        }

        public override object this[int index] 
        {
            set 
            { 
                base[index] = value;
                OnOperation?.Invoke(this, new ListOperationEventArgs
                {
                    Operation = OperationType.Update,
                    Value = value,
                    Time = DateTime.Now
                });
            }
        }

        public override void Remove(object obj) 
        { 
            base.Remove(obj);
            OnOperation?.Invoke(this, new ListOperationEventArgs
            {
                Operation = OperationType.Delete,
                Value = obj,
                Time = DateTime.Now
            });
        }
    }
}

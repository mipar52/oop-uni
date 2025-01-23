using System;

namespace delegate_practice1.ModelTwo
{
    public class CarArrivedEventArgs: EventArgs
    {
        public Car Car { get; set; }
    }
}
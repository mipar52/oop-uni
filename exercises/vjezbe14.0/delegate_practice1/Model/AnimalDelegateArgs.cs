using System;

namespace delegate_practice1.Model
{
    public class AnimalDelegateArgs: EventArgs
    {
        public Animal Animal { get; set; }
    }
}
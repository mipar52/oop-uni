using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak04.Model
{
    class ClientHost
    {
        // we must put event, because it only allows += and -= operators!!!
        public event ClientArrivedDelegate OnClientArrived;

        public void ClientHasArrived(Client client) => OnClientArrived?.Invoke(this, new ClientArrivedEventArgs { Client = client });

        //{
        //    if (OnClientArrived != null)
        //    {
        //        OnClientArrived(this, new ClientArrivedEventArgs { Client = client });
        //    }
        //}
    }
}

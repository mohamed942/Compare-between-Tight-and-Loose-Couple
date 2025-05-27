using Loose_Couple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Couple
{
    public  class NotifactionService
    {
        private readonly INotifactionMode _notifactionMode;
        public NotifactionService(INotifactionMode notifactionMode)
        {
            _notifactionMode = notifactionMode;
        }

        public void notify()
        {
            _notifactionMode.Send();
        }
    }
}

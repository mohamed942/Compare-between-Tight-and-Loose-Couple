using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compostion
{
    public  class NotifactionService
    {
        private readonly mailService _mailService;
        private readonly SmsService _smsService;
        public NotifactionService(mailService mailService, SmsService smsService)
        {
            _mailService = mailService;
            _smsService = smsService;
        }

        public void notify()
        {
            _mailService.send();
            _smsService.send();
        }
    }
}

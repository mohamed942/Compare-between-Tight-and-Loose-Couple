using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tight_Couple
{
    public  class NotifactionService
    {
        private readonly MailService _mailService;
        private readonly SmsService _smsService;
        public NotifactionService(MailService mailService, SmsService smsService)
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

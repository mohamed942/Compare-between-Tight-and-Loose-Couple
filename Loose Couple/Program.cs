
namespace Loose_Couple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mailService = new MailService();
            var smsService = new SmsService();
            var mailNotifactionService = new NotifactionService(mailService);
            mailNotifactionService.notify();
            var smsNotifactionService = new NotifactionService(smsService);
            smsNotifactionService.notify();
            Console.ReadKey();
        }
    }
}

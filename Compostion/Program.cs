namespace Tight_Couple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotifactionService notifactionService = new NotifactionService(new MailService()
                , new SmsService());
            notifactionService.notify();
            Console.ReadKey();
        }
    }
}
// inheratnce  is Relateion 
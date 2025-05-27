namespace Compostion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotifactionService notifactionService = new NotifactionService(new mailService()
                , new SmsService());
            notifactionService.notify();
            Console.ReadKey();
        }
    }
}
// inheratnce  is Relateion 
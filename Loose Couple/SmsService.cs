using Loose_Couple;

namespace Loose_Couple
{
    public class SmsService : INotifactionMode
    {
        public void Send()
        {
            Console.WriteLine("SMS sent");
        }
    }
}

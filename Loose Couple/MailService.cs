using Loose_Couple;

namespace Loose_Couple
{
    public class MailService : INotifactionMode
    {

        public void Send() {
            Console.WriteLine("mail sent"); 
        }
    }
}

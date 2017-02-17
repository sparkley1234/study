using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeSOLID
{
    class DIP
    {
    }
    ///
    /// <summary>
    /// public class Email
    //{
    //    public void SendEmail()
    //    {
    //        // code to send mail
    //    }
    //}
    //public class Notification
    //{
    //    private Email _email;
    //    public Notification()
    //    {
    //        _email = new Email();
    //    }
    //    public void PromotionalNotification()
    //    {
    //        _email.SendEmail();
    //    }
    //}
    ///Now Notification class totally depends on Email class, because it only sends one type of notification. 
    ///If we want to introduce any other like SMS then? We need to change the notification system also. And this is called tightly coupled. 
    ///What can we do to make it loosely coupled? Ok, check the following implementation.
    /// </summary>
    /// 
    ///
    ///I have chnaged to some extent BUT Still Notification class depends on Email class. 
    ///Now, we can use dependency injection so that we can make it loosely coupled. 
    public interface IMessenger
    {
        void SendMessage();
    }
    public class Email : IMessenger
    {
        public void SendMessage()
        {
            // code to send email
        }
    }

    public class SMS : IMessenger
    {
        public void SendMessage()
        {
            // code to send SMS
        }
    }
    public class Notification
    {
        private IMessenger iMessenger;
        public Notification()
        {
            iMessenger = new Email();
        }
        public void DoNotify()
        {
            iMessenger.SendMessage();
        }
    }
}

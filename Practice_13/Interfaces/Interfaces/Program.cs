using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var smsNotificator = new SmSNotificationManager();
            var emailNotificator = new EmailNotificationManager();
            var notificationThreshold = 500;
            var toolsCalculator = new ToolsCalculator(emailNotificator, notificationThreshold);

            ((IEmailNotificator)emailNotificator).Notify();
            
        }

        class ToolsCalculator
        {
            readonly INotificator _notificator;            
            readonly int _notificationThreshold;
            int _counter = 0;

            public ToolsCalculator(INotificator notificator, int notificationThreshold)
            {
                _notificationThreshold = notificationThreshold;
            }

            void Calculate()
            {
                _counter++;

                if(_counter == _notificationThreshold)
                {
                    _notificator.Notify();
                    _counter = 0;
                }
            }
        }

        class NotificationManager : INotificator
        {
            public void Notify()
            {
                throw new NotImplementedException();
            }
        }

        class SmSNotificationManager : INotificator
        {
            public void Notify()
            {
                throw new NotImplementedException();
            }
        }

        class EmailNotificationManager : INotificator, IEmailNotificator
        {
            void INotificator.Notify()
            {
                throw new NotImplementedException();
            }

            void IEmailNotificator.Notify()
            {
                throw new NotImplementedException();
            }
        }
    }

    internal interface INotificator
    {
        void Notify();
    }

    internal interface IEmailNotificator
    {
        void Notify();
    }
}

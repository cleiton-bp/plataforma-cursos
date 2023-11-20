using System.Collections.Generic;
using plataformaCursos.NotificationContext;
using plataformaCursos.SharedContext;

namespace plataformaCursos.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Name { get; set; }

        public string Email { get; set; }

        public User User { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPrimium)
            {
                AddNotification(new Notification("Premium", "O aluno ja tem assinatura ativa"));
                return;
            }
            Subscriptions.Add(subscription);
        }

        public bool IsPrimium => Subscriptions.Any(x => !x.IsInactive);
    }
}
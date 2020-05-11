using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    class ScoreSubject : ISubject
    {
        IList<IObserver> listObservers = new List<IObserver>();
        private int score;
        public int Score { get { return score; }
            set {
                score = value;
                Notify();
            } }
        public void Register(IObserver observer) {
            listObservers.Add(observer);
        }

        public void Unregister(IObserver observer) {
            listObservers.Remove(observer);
        }

        public void Notify() {
            listObservers.ToList().ForEach((observer) =>
            {
                observer.ScoreUpdated(Score);
            });
        }
    }
}

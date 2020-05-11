using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ScoreSubject scoreSubject = new ScoreSubject();

            IObserver indObserver = new INDObserver();

            IObserver ausObserver = new AUSObserver();

            scoreSubject.Register(indObserver);
            scoreSubject.Score = 10;
            scoreSubject.Register(ausObserver);
            scoreSubject.Score = 100;
            Console.ReadLine();
        }
    }
}

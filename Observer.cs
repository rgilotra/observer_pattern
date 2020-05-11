using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    class INDObserver : IObserver
    {
        public void ScoreUpdated(int score) {

            Console.WriteLine("Current Score : " + score);
        }
    }

    class AUSObserver : IObserver
    {
        public void ScoreUpdated(int score)
        {
            Console.WriteLine("Current Score : " + score);
        }
    }

    
}

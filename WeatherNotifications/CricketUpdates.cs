using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherNotifications
{
    class CricketUpdates
    {
        public int ball { get; set; }

        public int overs { get; set; }

        public int target { get; set; }

        public string batsman { get; set; }
        public int score { get; set; }

        public int MaximumOvers { get; set; } = 20;

       
        public delegate void listener(string msg);
        public delegate void listener<T>(T msg);

        //private listener Handler;

        public event listener GetCricketUpdate;

        public delegate void RemoteUpdateDelegate(int statusCode , string message);

        //public void SubsribeToCricketUpdates(listener listener)
        //{
        //    Handler += listener;
        //}

        //public void UnSubsribeToCricketUpdates(listener listener)
        //{
        //    Handler -= listener;
        //    //Delegate.Remove()
        //}

        public void StartInningsOver(int overNo)
        {
            if (overNo < MaximumOvers)
            {
                if (overNo == 19)
                {
                    
                }
                else
                {
                    GetCricketUpdate(" ---- ");
                    //Handler.Invoke(" Match is about to finish ");
                }
            }
            else
            {
                    Handler.Invoke(" Match is over ");
                
            }
        }

    }
}

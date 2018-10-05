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

       
        //public delegate void listener(object sender , EventArgs e);

        public delegate void listener(object sender , CricketEventArgs e);
        public delegate void listenerForMsg(string msg);
       // public delegate void listener<T>(T msg);

        //private listener Handler;

        public event listener GetCricketUpdate;
        public event listenerForMsg GetCricketUpdateMsg;

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
                    //if (GetCricketUpdate != null)
                    //{
                    //    GetCricketUpdate(" ---- ");

                    //}
                    GetCricketUpdateMsg?.Invoke("message from call back");
                    GetCricketUpdate?.Invoke(this , new CricketEventArgs {  message = "you are out"});
                }
            }
            else
            {
                    //Handler.Invoke(" Match is over ");
                
            }
        }

    }
}

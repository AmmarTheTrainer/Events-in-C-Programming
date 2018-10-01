using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherNotifications
{
    public delegate void UIDelegate(string UIMessage);
    class Program
    {
        static void Main(string[] args)
        {
            CricketUpdates cricketUpdates = new CricketUpdates();

            // UIDelegate uIDelegate = UpdateUI;    Method Conversion Syntax

            //cricketUpdates.SubsribeToCricketUpdates(UpdateUI);
            //cricketUpdates.SubsribeToCricketUpdates(UpdateUI2);

            //cricketUpdates.StartInningsOver(21);

            //Console.WriteLine("\n unsubscribtion done.. \n");
            //cricketUpdates.UnSubsribeToCricketUpdates(UpdateUI2);

            cricketUpdates.GetCricketUpdate += UpdatesFORCricket;
            cricketUpdates.GetCricketUpdate += MycustomUpdates;

            cricketUpdates.StartInningsOver(21);

            ObservableCollection<int> bsc = new ObservableCollection<int>();
            bsc.CollectionChanged += Bsc_CollectionChanged;

            Console.ReadLine();
        }

        private static void Bsc_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void MycustomUpdates(string msg)
        {
    
        }

        private static void UpdatesFORCricket(string msg)
        {

        }

        private static void UpdateUI(string msg)
        {
            Console.WriteLine(" Subcriber No 1 ");
            Console.WriteLine(msg);
        }
        private static void UpdateUI(string heading, string message)
        {
            Console.WriteLine(" Subcriber No 1 ");
            Console.WriteLine(heading +"\n" + message);
        }
        private static void UpdateUI2(string msg)
        {
            Console.WriteLine(" Subcriber No 2 ");

            Console.WriteLine(msg);
        }

        private static double add(int a , int  b)
        {
            return a + b;
        }
    }
}

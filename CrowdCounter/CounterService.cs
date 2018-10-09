using System;
using System.Threading;
using CrowdCounterAPI.Model;

namespace CrowdCounterAPI
{
    public class CounterService
    {

        public CounterService()
        {
        }

        private CrowdFlow ProcessFlow(){
            Random r = new Random((int)DateTimeOffset.Now.ToUnixTimeMilliseconds());
            byte amount = (byte)r.Next(5);
            FlowDirection dir = (FlowDirection)((amount + r.Next(33)) % 2);
            return new CrowdFlow(amount, dir);
        }

        public void StartProcessing(){
             new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                while(true){
                    CrowdFlow flow = ProcessFlow();

                    //voeg een delegate to om de informatie op te vragen en weer te geven op je scherm.
                    //wordt enkel uitgevoerd indien het # personen > 0
                    Thread.Sleep(1500);
                }
            }).Start();
        }
    }
}

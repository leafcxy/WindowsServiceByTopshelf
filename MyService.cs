using System;
using System.Threading;
using Topshelf;

namespace WindowsServiceByTopshelf
{
    //public partial class MyService : ServiceBase
    //{
    //    public MyService()
    //    {
    //        InitializeComponent();
    //    }

    //    protected override void OnStart(string[] args)
    //    {
    //    }

    //    protected override void OnStop()
    //    {
    //    }
    //}

    public class MyService
    {
        public void Start()
        {
            Console.WriteLine("Service started.");
            Logs.Write("Service started.");

            while (true)
            {
                Logs.Write("Service doing somethings.");
                Thread.Sleep(2000);
            }
        }

        public void Stop()
        {
            Console.WriteLine("Service stopped.");
            Logs.Write("Service stopped.");
        }
    }
}

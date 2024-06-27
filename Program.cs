using System;
using Topshelf;

namespace WindowsServiceByTopshelf
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[]
            //{
            //    new MyService()
            //};
            //ServiceBase.Run(ServicesToRun);

            HostFactory.Run(x =>
            {
                x.Service<MyService>(s =>
                {
                    s.ConstructUsing(name => new MyService());
                    s.WhenStarted(service => service.Start());
                    s.WhenStopped(service => service.Stop());
                });

                x.SetServiceName("MySuperService");
                x.SetDisplayName("My Super Service");
                x.SetDescription("This is an example of a Topshelf service.");

                // 设置服务启动类型：手动、自动或禁用
                x.RunAsLocalSystem(); // 或者使用其他账户，如NetworkService、LocalService等
                x.StartAutomatically(); // 或者 StartManually、StartOnDemand

                //x.UseNLog(); // 如果你使用NLog作为日志框架
            });
        }
    }
}

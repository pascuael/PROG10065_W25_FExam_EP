using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace PROG10065_W25_FExam_EP
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}

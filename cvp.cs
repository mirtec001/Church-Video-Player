// MyApp.cs
using System;
using System.Windows;
using System.Windows.Controls;

namespace CVPApp
{
    public partial class VideoPlayer : Application
    {
        void AppStartup(object sender, StartupEventArgs e)
        {
        // By default, when all top level windows
        // are closed, the app shuts down
        Window window = new Window1();
        window.Show();
        }
    }
}
// Window2.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls; // Button et al

using Microsoft.Win32;

namespace CVPApp
{
    public partial class Window2 : Window
    {

        private List<string> folders = new List<string>();
        private string fn = "";
        public Window2(string filename)
        {
           InitializeComponent();
           fn = filename;
        }
        public void PlayMedia()
        {
            VideoControl.Source = new Uri(@fn);
            if (VideoControl.Source != null)
            {
                VideoControl.Play();
            }
            else
            {
                MessageBox.Show("Sorry boss,\nYou suck balls", "No Media Found", MessageBoxButton.OK);
            }
            
        }
        public void StopMedia()
        {
            VideoControl.Stop();
        }
    }
}
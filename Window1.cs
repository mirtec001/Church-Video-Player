// Window1.cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls; // Button et al

using Microsoft.Win32;

namespace CVPApp
{
    public partial class Window1 : Window
    {

        private List<string> folders = new List<string>();
        private Window2 win2;

        public Window1()
        {
           InitializeComponent();
        }

        private void OpenClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Nullable<bool> result = ofd.ShowDialog();
            
            if (result == true)
            {
                // folders.Add(ofd.FileName);
                string[] files = Directory.GetFiles(Path.GetDirectoryName(@ofd.FileName));
                foreach (string filenm in files)
                {
                  lb.Items.Add(filenm);  
                }
                //lb.ItemsSource = folders;
            }
        }

        private void PlayClick(object sender, EventArgs e)
        {
            if (lb.SelectedItem != null)
            {
                win2 = new Window2(lb.SelectedItem.ToString());
                win2.WindowStartupLocation = WindowStartupLocation.Manual;
                win2.Left = 1912;
                win2.Top = 0;
                win2.Width = 1945;
                win2.Height = 1225;
                win2.WindowStyle = WindowStyle.None;
                win2.Show();
                win2.PlayMedia();
            }
        }
        private void StopClick(object sender, EventArgs e)
        {
            win2.StopMedia();
        }
        
        private void CloseClick(object sender, EventArgs e)
        {
            win2.Close();
            // this.Close();
        }
    }
}
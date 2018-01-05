﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SpikeContainer.Spike_001
{
    /// <summary>
    /// Interaction logic for MyUserControl1.xaml
    /// </summary>
    public partial class MyUserControl1 : UserControl
    {
        public MyUserControl1()
        {
            InitializeComponent();
        }

        private void KeyOne_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowsInput.InputSimulator.SimulateKeyPress(WindowsInput.VirtualKeyCode.NUMPAD1);
        }
    }
}

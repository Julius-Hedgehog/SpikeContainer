using System;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Trace.WriteLine(string.Format("gridView1_KeyUp {0}  {1} ", e.ToString(), e.ToString()));

            KeyEventArgs keyEventArgs = new KeyEventArgs(KeyboardDevice,Key.NumPad6);
            OnKeyDown(keyEventArgs);

            //KeyDownEvent routedEvent = 
            
        }

        protected override void OnMouseLeave(MouseEventArgs e)
        {
            base.OnMouseLeave(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }
    }
}

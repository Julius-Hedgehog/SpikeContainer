using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SpikeContainer.SPIKE_015
{
    public partial class XtraForm3 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm3()
        {
            InitializeComponent();

            this.Resize += XtraForm3_Resize;
            szPreviousResize = this.Size;
            szPreviousSizeChngd = this.Size;
        }

        Size szPreviousResize = new Size(0, 0);
        Size szPreviousSizeChngd = new Size(0, 0);


        private void XtraForm3_Resize(object sender, EventArgs e)
        {
            // mathmatically force square-ness
            if (this.Size.Width != szPreviousResize.Width
                || this.Size.Height != szPreviousResize.Height)
            {
                // i have a size change

                // ? ? IS SIZE CHANGE INCREASE ?? 
                // OR 
                // ? ? IS SIZE DECREASE ??

                if (this.Size.Width >= szPreviousResize.Width
                || this.Size.Height >= szPreviousResize.Height)
                {
                    // absolute increase , both width and height increased
                }

                if (this.Size.Width < szPreviousResize.Width
                || this.Size.Height < szPreviousResize.Height)
                {
                    // absolute decrease, both width and height decreased
                }

            }
        }

        private void XtraForm3_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
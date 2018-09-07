using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SpikeContainer.SPIKE_015
{
    public partial class XtraUserControl1 : DevExpress.XtraEditors.XtraUserControl
    {
        public XtraUserControl1()
        {
            InitializeComponent();

            labelControl1.Resize += LabelControl1_Resize;
            this.Resize += XtraUserControl1_Resize;

            szLabelSizeChngd = labelControl1.Size;
            szControlSizeChngd = this.Size;

            szLabelReSize = labelControl1.Size;
            szControlReSize = this.Size;

            string var = string.Format("Size:\r\n{0}\r\nPos:{1}", labelControl1.Size.ToString(), labelControl1.Location.ToString());
            labelControl1.Text = var;
        }

        Size szLabelSizeChngd;
        Size szControlSizeChngd;

        Size szLabelReSize;
        Size szControlReSize;

        //$@"Size:{0} \n\r Pos:{1}"

        private void LabelControl1_Resize(object sender, EventArgs e)
        {
            string var = string.Format("Size:\r\n{0}\r\nPos:{1}", labelControl1.Size.ToString(), labelControl1.Location.ToString());
            labelControl1.Text = var;
            labelControl1.Refresh();
            this.Refresh();
        }

        private void labelControl1_SizeChanged(object sender, EventArgs e)
        {
            string var = string.Format("Size:\n\r{0}\n\rPos:{1}", labelControl1.Size.ToString(), labelControl1.Location.ToString());
            labelControl1.Text = var;
            labelControl1.Refresh();
            this.Refresh();
        }

        private void XtraUserControl1_SizeChanged(object sender, EventArgs e)
        {

        }
        private void XtraUserControl1_Resize(object sender, EventArgs e)
        {

        }
    }
}

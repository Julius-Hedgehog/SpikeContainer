using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikeContainer.Spike_001
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Spike001V1 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Spike001V1()
        {
            InitializeComponent();

            this.tenKeypadControl11.CustTenKeyEvent += OnTenKeyClick;

            this.tenKeypadControl11.Enabled = false;

            this.textEdit2.Text = "0";
            this.textEdit3.Text = "0";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Spike One is a development test bed for the creation of a 'Numeric Keypad' control for touch screen usage.", "About: Spike One", MessageBoxButtons.OK);
        }

        private void OnTenKeyClick(object sender, TenKeypadContol1EventArgs e)
        {
            if (IsTareWeightSelected)
            {
                this.textEdit3.Text = (e.DISPLAY.Length == 0 ? "0" : e.DISPLAY);
            }
            else if(IsGrossWeightSelected)
            {
                this.textEdit2.Text = (e.DISPLAY.Length == 0 ? "0" : e.DISPLAY);
            }
        }


        private bool IsGrossWeightSelected = false;
        private bool IsTareWeightSelected = false;
        private void textEdit2_Click(object sender, EventArgs e)
        {
            if (!IsGrossWeightSelected)
            {
                this.tenKeypadControl11.Enabled = true;
                this.tenKeypadControl11.CurrentValue = (this.textEdit2.Text == "0" ? "" : this.textEdit2.Text);

                IsTareWeightSelected = false;
                this.textEdit3.BackColor = Color.White;

                IsGrossWeightSelected = true;
                this.textEdit2.BackColor = Color.LightYellow;
            }
            else
            {
                this.tenKeypadControl11.Enabled = false;

                IsGrossWeightSelected = false;
                this.textEdit2.BackColor = Color.White;
            }
        }

        private void textEdit3_Click(object sender, EventArgs e)
        {
            if (!IsTareWeightSelected)
            {
                this.tenKeypadControl11.Enabled = true;
                this.tenKeypadControl11.CurrentValue = (this.textEdit3.Text == "0" ? "" : this.textEdit3.Text); ;

                IsGrossWeightSelected = false;
                this.textEdit2.BackColor = Color.White;

                IsTareWeightSelected = true;
                this.textEdit3.BackColor = Color.LightYellow;
            }
            else
            {
                this.tenKeypadControl11.Enabled = false;

                IsTareWeightSelected = false;
                this.textEdit3.BackColor = Color.White;
            }
        }
    }
}

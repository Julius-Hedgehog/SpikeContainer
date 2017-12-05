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
    public partial class Spike001V0 : Form
    {

        private string strKeyText = "";


        /// <summary>
        /// 
        /// </summary>
        public Spike001V0()
        {
            InitializeComponent();

            // - - - - - - - - - - - - -
            // >> KEYPAD EVENT HANDLERS
            // ..
            // The keypad passes through as publicly visible the keys and the key events
            // this allows the parent to easly and with the greatest flexibility to handle
            // and control the keypad
            this.tenKeypadControl1.KeyDecimal.Click += this.TenKeypadControl1Key_Click;
            this.tenKeypadControl1.Key00.Click += this.TenKeypadControl1Key_Click;
            this.tenKeypadControl1.Key01.Click += this.TenKeypadControl1Key_Click;
            this.tenKeypadControl1.Key02.Click += this.TenKeypadControl1Key_Click;
            this.tenKeypadControl1.Key03.Click += this.TenKeypadControl1Key_Click;
            this.tenKeypadControl1.Key04.Click += this.TenKeypadControl1Key_Click;
            this.tenKeypadControl1.Key05.Click += this.TenKeypadControl1Key_Click;
            this.tenKeypadControl1.Key06.Click += this.TenKeypadControl1Key_Click;
            this.tenKeypadControl1.Key07.Click += this.TenKeypadControl1Key_Click;
            this.tenKeypadControl1.Key08.Click += this.TenKeypadControl1Key_Click;
            this.tenKeypadControl1.Key09.Click += this.TenKeypadControl1Key_Click;
            // - - - - - - - - - - - - -
            this.tenKeypadControl1.KeyCE.Click += this.TenKeypadControlKeyCE_Click;

        }

        // - - - - - - - - - - - - -
        // >> KEYPAD EVENT HANDLERS
        // any standard #numeric key or decimal period key
        // pushes into the output text member
        private void TenKeypadControl1Key_Click(object sender, EventArgs e)
        {

            DevExpress.XtraEditors.SimpleButton btn = (DevExpress.XtraEditors.SimpleButton)sender;
            switch (btn.Tag)
            {
                case "0":
                    this.strKeyText += "0"; 
                    break;
                case "1":
                    this.strKeyText += "1";
                    break;
                case "2":
                    this.strKeyText += "2";
                    break;
                case "3":
                    this.strKeyText += "3";
                    break;
                case "4":
                    this.strKeyText += "4";
                    break;
                case "5":
                    this.strKeyText += "5";
                    break;
                case "6":
                    this.strKeyText += "6";
                    break;
                case "7":
                    this.strKeyText += "7";
                    break;
                case "8":
                    this.strKeyText += "8";
                    break;
                case "9":
                    this.strKeyText += "9";
                    break;
                default:
                    // only one decimal point in string
                    if (!this.strKeyText.Contains("."))
                    {
                        if(this.strKeyText.Length == 0)
                        {
                            this.strKeyText += "0";
                        }
                        this.strKeyText += ".";
                    }
                    break;
            }

            this.textBox1.Text = this.strKeyText;
        }

        // - - - - - - - - - - - - -
        // >> KEYPAD EVENT HANDLERS
        // the clear key
        private void TenKeypadControlKeyCE_Click(object sender, EventArgs e)
        {
            if (this.strKeyText.Length > 0)
            {
                this.strKeyText = this.strKeyText.Remove(this.strKeyText.Length - 1);
            }
            this.textBox1.Text = this.strKeyText;
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Spike One is a development test bed for the creation of a 'Numeric Keypad' control for touch screen usage.", "About: Spike One", MessageBoxButtons.OK);
        }
    }
}

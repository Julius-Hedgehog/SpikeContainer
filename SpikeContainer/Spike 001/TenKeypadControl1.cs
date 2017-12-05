using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikeContainer.Spike_001
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TenKeypadControl1 : UserControl
    {
        private string _mstringCurrentKeypadValue = "";

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler<TenKeypadContol1EventArgs> CustTenKeyEvent;

        /// <summary>
        /// 
        /// </summary>
        public string CurrentValue
        {
            set { this._mstringCurrentKeypadValue = value; }
            get { return this._mstringCurrentKeypadValue; }
        }

        /// <summary>
        /// 
        /// </summary>
        public TenKeypadControl1()
        {
            InitializeComponent();

            // - - - - - - - - - - - - -
            // >> KEYPAD EVENT HANDLERS
            // ..
            // The keypad passes through as publicly visible the keys and the key events
            // this allows the parent to easly and with the greatest flexibility to handle
            // and control the keypad
            this.KeyDecimal.Click += this.TenKeypadControl1Key_Click;
            this.Key00.Click += this.TenKeypadControl1Key_Click;
            this.Key01.Click += this.TenKeypadControl1Key_Click;
            this.Key02.Click += this.TenKeypadControl1Key_Click;
            this.Key03.Click += this.TenKeypadControl1Key_Click;
            this.Key04.Click += this.TenKeypadControl1Key_Click;
            this.Key05.Click += this.TenKeypadControl1Key_Click;
            this.Key06.Click += this.TenKeypadControl1Key_Click;
            this.Key07.Click += this.TenKeypadControl1Key_Click;
            this.Key08.Click += this.TenKeypadControl1Key_Click;
            this.Key09.Click += this.TenKeypadControl1Key_Click;
            // - - - - - - - - - - - - -
            this.KeyCE.Click += this.TenKeypadControlKeyCE_Click;
        }

        // - - - - - - - - - - - - -
        // >> KEYPAD EVENT HANDLERS
        // any standard #numeric key or decimal period key
        // pushes into the output text member
        private void TenKeypadControl1Key_Click(object sender, EventArgs e)
        {
            Keys key = Keys.Decimal;
            DevExpress.XtraEditors.SimpleButton btn = (DevExpress.XtraEditors.SimpleButton)sender;
            switch (btn.Tag)
            {
                case "0":
                    this._mstringCurrentKeypadValue += "0";
                    key = Keys.NumPad0;
                    break;
                case "1":
                    this._mstringCurrentKeypadValue += "1";
                    key = Keys.NumPad1;
                    break;
                case "2":
                    this._mstringCurrentKeypadValue += "2";
                    key = Keys.NumPad2;
                    break;
                case "3":
                    this._mstringCurrentKeypadValue += "3";
                    key = Keys.NumPad3;
                    break;
                case "4":
                    this._mstringCurrentKeypadValue += "4";
                    key = Keys.NumPad4;
                    break;
                case "5":
                    this._mstringCurrentKeypadValue += "5";
                    key = Keys.NumPad5;
                    break;
                case "6":
                    this._mstringCurrentKeypadValue += "6";
                    key = Keys.NumPad6;
                    break;
                case "7":
                    this._mstringCurrentKeypadValue += "7";
                    key = Keys.NumPad7;
                    break;
                case "8":
                    this._mstringCurrentKeypadValue += "8";
                    key = Keys.NumPad8;
                    break;
                case "9":
                    this._mstringCurrentKeypadValue += "9";
                    key = Keys.NumPad9;
                    break;
                default:
                    // only one decimal point in string
                    if (!this._mstringCurrentKeypadValue.Contains("."))
                    {
                        if (this._mstringCurrentKeypadValue.Length == 0)
                        {
                            this._mstringCurrentKeypadValue += "0";
                        }
                        this._mstringCurrentKeypadValue += ".";
                        key = Keys.Decimal;
                    }
                    break;
            }

            TenKeypadContol1EventArgs args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, key);

            this.OnCustTenKeyEvent(args);
        }

        // - - - - - - - - - - - - -
        // >> KEYPAD EVENT HANDLERS
        // the clear key
        private void TenKeypadControlKeyCE_Click(object sender, EventArgs e)
        {
            if (this._mstringCurrentKeypadValue.Length > 0)
            {
                this._mstringCurrentKeypadValue = this._mstringCurrentKeypadValue.Remove(this._mstringCurrentKeypadValue.Length - 1);

                Keys key;
                key = Keys.Clear;
                TenKeypadContol1EventArgs args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, key);

                this.OnCustTenKeyEvent(args);
            }
        }

        /// <summary>
        /// The event to be handled in the parent that 
        /// </summary>
        /// <param name="args"></param>
        protected void OnCustTenKeyEvent(TenKeypadContol1EventArgs args)
        {
            EventHandler<TenKeypadContol1EventArgs> handler = CustTenKeyEvent;
            if (handler != null)
            {
                handler(this, args);
            }
        }

        private void KeyOK_Click(object sender, EventArgs e)
        {
            Keys key = Keys.Y;
            TenKeypadContol1EventArgs args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, key);
            this.OnCustTenKeyEvent(args);
        }

        private void KeyCancel_Click(object sender, EventArgs e)
        {
            Keys key = Keys.N;
            TenKeypadContol1EventArgs args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, key);

            this.OnCustTenKeyEvent(args);
        }

    }
}

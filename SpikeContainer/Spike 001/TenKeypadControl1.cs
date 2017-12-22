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

    #region [ Enumerations ]

    #endregion


    /// <summary>
    /// 
    /// .......DESIGN NOTE
    /// - - - the TenKeypadControl1.Designer.cs
    /// - - -                       may need the declaration of 
    /// - - - private DevExpress.XtraEditors.PanelControl KeypadKeyPanel;
    /// - - -   AS AS AS
    /// - - - public DevExpress.XtraEditors.PanelControl KeypadKeyPanel;
    /// 
    /// </summary>
    public partial class TenKeypadControl1 : UserControl
    {
        #region [ Members ]
        // Nested Types
        // Constants
        // Delegates
        // Events
        // Fields

        private string _mstringCurrentKeypadValue = "";

        /// <summary>
        /// Event definition declaration
        /// </summary>
        public event EventHandler<TenKeypadContol1EventArgs> CustTenKeyEvent;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Default Construction
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

        #endregion

        #region [ Propereties ]

        /// <summary>
        /// Returns the current value of the last key pressed on control
        /// </summary>
        public string CurrentValue
        {
            set { this._mstringCurrentKeypadValue = value; }
            get { return this._mstringCurrentKeypadValue; }
        }

        #endregion

        #region [ Methods ]

        #region [ IDisposable ]

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion

        #region [ Events ]

        // - - - - - - - - - - - - -
        // >> KEYPAD EVENT HANDLERS
        // any standard #numeric key or decimal period key
        // pushes into the output text member
        private void TenKeypadControl1Key_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton btn = (DevExpress.XtraEditors.SimpleButton)sender;
            TenKeypadContol1EventArgs args = null;
            string key = "1";

            switch (btn.Tag)
            {

                case "0":
                    this._mstringCurrentKeypadValue += "0";
                    args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, Keys.NumPad0);
                    key = "0";
                    break;
                case "1":
                    this._mstringCurrentKeypadValue += "1";
                    args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, Keys.NumPad1);
                    key = "1";
                    break;
                case "2":
                    this._mstringCurrentKeypadValue += "2";
                    args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, Keys.NumPad2);
                    key = "2";
                    break;
                case "3":
                    this._mstringCurrentKeypadValue += "3";
                    args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, Keys.NumPad3);
                    key = "3";
                    break;
                case "4":
                    this._mstringCurrentKeypadValue += "4";
                    args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, Keys.NumPad4);
                    key = "4";
                    break;
                case "5":
                    this._mstringCurrentKeypadValue += "5";
                    args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, Keys.NumPad5);
                    key = "5";
                    break;
                case "6":
                    this._mstringCurrentKeypadValue += "6";
                    args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, Keys.NumPad6);
                    key = "6";
                    break;
                case "7":
                    this._mstringCurrentKeypadValue += "7";
                    args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, Keys.NumPad7);
                    key = "7";
                    break;
                case "8":
                    this._mstringCurrentKeypadValue += "8";
                    args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, Keys.NumPad8);
                    key = "8";
                    break;
                case "9":
                    this._mstringCurrentKeypadValue += "9";
                    args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, Keys.NumPad9);
                    key = "9";
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
                        args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, Keys.Decimal);
                        key = ".";
                    }
                    break;
            }

            this.OnCustTenKeyEvent(key, args);
        }

        // - - - - - - - - - - - - -
        // >> KEYPAD EVENT HANDLERS
        // the clear key
        private void TenKeypadControlKeyCE_Click(object sender, EventArgs e)
        {
            if (this._mstringCurrentKeypadValue.Length > 0)
            {
                this._mstringCurrentKeypadValue = this._mstringCurrentKeypadValue.Remove(this._mstringCurrentKeypadValue.Length - 1);
                TenKeypadContol1EventArgs args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, Keys.Clear);

                this.OnCustTenKeyEvent("{BACKSPACE}",args);
            }
        }

        /// <summary>
        /// >> KEYPAD EVENT HANDLERS
        /// the OK key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyOK_Click(object sender, EventArgs e)
        {
            TenKeypadContol1EventArgs args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, Keys.Y);
            this.OnCustTenKeyEvent("{ENTER}",args);
        }

        /// <summary>
        /// >> KEYPAD EVENT HANDLERS
        /// the NO key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyCancel_Click(object sender, EventArgs e)
        {
            TenKeypadContol1EventArgs args = new TenKeypadContol1EventArgs(_mstringCurrentKeypadValue, Keys.N);
            this.OnCustTenKeyEvent("{ESC}",args);
        }

        #endregion

        #region [ Implementation ]

        /// <summary>
        /// Custom Event Definition
        /// The event to be handled in the parent that displays the control
        /// 
        /// this is declared protected here so it is private in the parent class
        /// 
        /// </summary>
        /// <param name="args"> <see cref="TenKeypadContol1EventArgs"/></param>
        protected void OnCustTenKeyEvent(string key, TenKeypadContol1EventArgs args)
        {
            EventHandler<TenKeypadContol1EventArgs> handler = CustTenKeyEvent;
            if (handler != null)
            {
                handler(this, args);
                //SendKeys.SendWait(key); // NO NO NO - this dont work - as I thought it did not do.
            }
        }

        #endregion

        #endregion

    }
}

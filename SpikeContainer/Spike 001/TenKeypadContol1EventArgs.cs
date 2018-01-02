using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikeContainer.Spike_001
{
    /// <summary>
    /// 
    /// </summary>
    public class TenKeypadContol1EventArgs : EventArgs
    {
        private string strDisplay = "";
        private Keys keyeventKey;
        private string strKeyval = "";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="keys"></param>
        public TenKeypadContol1EventArgs(string str, Keys keys, string value)
        {
            this.strDisplay = str;
            this.keyeventKey = keys;
            strKeyval = value;
        }
        /// <summary>
        /// 
        /// </summary>
        public string DISPLAY
        {
            get { return this.strDisplay; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Keys KEY
        {
            get { return this.keyeventKey; }
        }

        public string VAL
        {
            get { return strKeyval; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
//******************************************************************************************************
// TenKeypadContol1EventArgs.cs - PTM Custom Components: Assembly - PTM Custom Components: Solution - PTM Custom Components: Prioject
//
// Copyright © 2017, Polartec Tennesee Manufacturing LLC. All Rights Reserved.
//
// Unless agreed to in writing, the subject software distributed under the License is distributed on an
// "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
// License for the specific language governing permissions and limitations.
//
//******************************************************************************************************

using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikeContainer.Spike_001_SPUR_001
{
    public partial class ClearClearEntryKeyPadControl : UserControl
    {
        public ClearClearEntryKeyPadControl()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            WindowsInput.InputSimulator.SimulateKeyPress(WindowsInput.VirtualKeyCode.HOME);
            for (Int32 j = 0; j < 99; j++) { WindowsInput.InputSimulator.SimulateKeyPress(WindowsInput.VirtualKeyCode.DELETE); }
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {
            WindowsInput.InputSimulator.SimulateKeyPress(WindowsInput.VirtualKeyCode.BACK);
        }
    }
}

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
    public partial class TenKeyPadControl1_1 : UserControl
    {
        public TenKeyPadControl1_1()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            WindowsInput.InputSimulator.SimulateKeyPress(WindowsInput.VirtualKeyCode.NUMPAD1);
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {
            WindowsInput.InputSimulator.SimulateKeyPress(WindowsInput.VirtualKeyCode.NUMPAD2);
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {
            WindowsInput.InputSimulator.SimulateKeyPress(WindowsInput.VirtualKeyCode.NUMPAD3);
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {
            WindowsInput.InputSimulator.SimulateKeyPress(WindowsInput.VirtualKeyCode.NUMPAD4);
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {
            WindowsInput.InputSimulator.SimulateKeyPress(WindowsInput.VirtualKeyCode.NUMPAD5);
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {
            WindowsInput.InputSimulator.SimulateKeyPress(WindowsInput.VirtualKeyCode.NUMPAD6);
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {
            WindowsInput.InputSimulator.SimulateKeyPress(WindowsInput.VirtualKeyCode.NUMPAD7);
        }

        private void labelControl8_Click(object sender, EventArgs e)
        {
            WindowsInput.InputSimulator.SimulateKeyPress(WindowsInput.VirtualKeyCode.NUMPAD8);
        }

        private void labelControl9_Click(object sender, EventArgs e)
        {
            WindowsInput.InputSimulator.SimulateKeyPress(WindowsInput.VirtualKeyCode.NUMPAD9);
        }

        private void labelControl10_Click(object sender, EventArgs e)
        {
            WindowsInput.InputSimulator.SimulateKeyPress(WindowsInput.VirtualKeyCode.NUMPAD0);
        }

        private void labelControl11_Click(object sender, EventArgs e)
        {
            WindowsInput.InputSimulator.SimulateKeyPress(WindowsInput.VirtualKeyCode.DECIMAL);
        }
    }
}

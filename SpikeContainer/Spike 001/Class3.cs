using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;

namespace SpikeContainer.Spike_001
{
    public abstract class ModifierKeyBase : VirtualKey
    {
        private bool _isInEffect;

        public bool IsInEffect
        {
            get { return _isInEffect; }
            set
            {
                if (value != _isInEffect)
                {
                    _isInEffect = value;
                    OnPropertyChanged("IsInEffect");
                }
            }
        }

        protected ModifierKeyBase(VirtualKeyCode keyCode) :
            base(keyCode)
        {
        }

        public abstract void SynchroniseKeyState();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_process
{
    internal enum state
    { 
        Running,
        Paused,
        Stopped
    }
    class Process
    {
        private state _curentState;
        public state CurrentState
        {
            get
            {
                return _curentState;
            }
        }
        public void Start(state)
        {
            if (_curentState != state.Running)
                _curentState = state.Running;

        }
        public void Paused(state)
        {
            if (_curentState == state.Running)
                _curentState = state.Paused;
        }
        
        public void Stopped(state)
        {
            if (_curentState == state.Running)
                _curentState = state.Stopped;


        }
    }
}

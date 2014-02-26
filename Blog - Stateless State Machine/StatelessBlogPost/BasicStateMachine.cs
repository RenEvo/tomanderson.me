using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatelessBlogPost
{
    public class BasicStateMachine
    {
        public string State { get; private set; }

        public void TransitionToState(string state)
        {
            switch (state)
            {
                case "on":
                    State = "ON";
                    OnSwitchedOn();
                    break;
                default:
                    State = "OFF";
                    OnSwitchedOff();
                    break;
            }
        }

        private void OnSwitchedOn()
        {
            // Do something clever
        }

        private void OnSwitchedOff()
        {
            // Stop doing something clever
        }
    }
}

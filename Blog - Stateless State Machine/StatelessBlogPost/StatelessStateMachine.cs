using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stateless;

namespace StatelessBlogPost
{
    public class StatelessStateMachine
    {
        private readonly StateMachine<State, Trigger> _stateMachine;

        public enum Trigger
        {
            TurnOn,
            TurnOff
        }

        public enum State
        {
            On,
            Off
        }

        public State Current { get { return _stateMachine.State; } }

        public StatelessStateMachine()
        {
            _stateMachine = new StateMachine<State, Trigger>(State.Off);
            _stateMachine.Configure(State.Off)
                .Permit(Trigger.TurnOn, State.On)
                .OnEntry(OnSwitchedOn);

            _stateMachine.Configure(State.On)
                .Permit(Trigger.TurnOff, State.Off)
                .OnEntry(OnSwitchedOff);
        }

        public bool Transition(Trigger trigger)
        {
            if (!_stateMachine.CanFire(trigger))
                return false;

            _stateMachine.Fire(trigger);

            return true;
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

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace StateMachine
{
    public class Sheets_State : State
    {

        public Sheets_State()
        {
            Options = new string[] { "Press Backspace to return to cell.\n" };
            Content = "You can't believe you sleep in these things. Surely it's " +
                        "time somebody changed them. The pleasures of prison life " +
                        "I guess!\n\n";
            SetOptionsDictionary(Options);

        }

        public override void DoTransition(int option)
        {
            throw new System.NotImplementedException();
        }

        public override State GetNextState(int option)
        {
            switch (option)
            {
                case 4:
                    return new Cell_State();
                default:
                    return this;
            }
        }
    }
}
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace StateMachine
{
    public class Mirror_State : State
    {
        
        public Mirror_State()
        {
            Options = new string[] { "Press 1 to take mirror\n", "Press Backspace to return to cell.\n" };            
            Content = "The dirty old mirror on the wall seems loose.\n\n";
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
                case 1: 
                    return new Cell_State();
                case 4:
                    return new Cell_State();
                default:
                    return this;
            }
        }
    }
}
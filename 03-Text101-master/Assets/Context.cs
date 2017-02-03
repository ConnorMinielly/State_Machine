using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class Context
    {
        Stack<State> currentStateStack = new Stack<State>();
        public State CurrentState { get; set; }

        public Context(State initState)
        {
            currentStateStack.Push(initState);
            CurrentState = currentStateStack.Peek();
        }

        public void UpdateContext(Text gameText)
        {            
            if (Input.GetKeyDown(KeyCode.Alpha1) && CurrentState.GetOptionCount() >= 1)
            {
                currentStateStack.Push(CurrentState.HandleSelection(1));
                CurrentState = currentStateStack.Peek();
            }
            if (Input.GetKeyDown(KeyCode.Alpha2) && CurrentState.GetOptionCount() >= 2)
            {
                currentStateStack.Push(CurrentState.HandleSelection(2));
                CurrentState = currentStateStack.Peek();
            }
            if (Input.GetKeyDown(KeyCode.Alpha3) && CurrentState.GetOptionCount() >= 3)
            {
                currentStateStack.Push(CurrentState.HandleSelection(3));
                CurrentState = currentStateStack.Peek();
            }
            if (Input.GetKeyDown(KeyCode.Alpha4) && CurrentState.GetOptionCount() >= 4)
            {
                currentStateStack.Push(CurrentState.HandleSelection(4));
                CurrentState = currentStateStack.Peek();
            }
            if (Input.GetKeyDown(KeyCode.Alpha5) && CurrentState.GetOptionCount() >= 5)
            {
                currentStateStack.Push(CurrentState.HandleSelection(5));
                CurrentState = currentStateStack.Peek();
            }
            if (Input.GetKeyDown(KeyCode.Backspace) )
            {
                currentStateStack.Pop().ReturnToLastState(0);
                CurrentState = currentStateStack.Peek();
            }
            gameText.text = CurrentState.GetStateContent();
        }
    }
}

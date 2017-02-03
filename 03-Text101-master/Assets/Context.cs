using System.Collections.Generic;
using StateMachine;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class Context
    {
        Stack<State> currentStateStack = new Stack<State>();
        public State currentState { get; set; }

        public Context(State initState)
        {
            currentStateStack.Push(initState);
            currentState = currentStateStack.Peek();
        }

        public void UpdateContext(Text GameText)
        {            
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                currentStateStack.Push(currentState.HandleSelection(1));
                currentState = currentStateStack.Peek();
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                currentStateStack.Push(currentState.HandleSelection(2));
                currentState = currentStateStack.Peek();
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                currentStateStack.Push(currentState.HandleSelection(3));
                currentState = currentStateStack.Peek();
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                currentStateStack.Pop().ReturnToLastState(4);
                currentState = currentStateStack.Peek();
            }
            GameText.text = currentState.GetStateContent();

        }
    }
}

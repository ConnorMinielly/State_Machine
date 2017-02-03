using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public abstract class State
    {  
        protected State NextState;

        //protected Dictionary<int, string> OptionsDictionary = new Dictionary<int, string>();
        protected string[] Options { get; set; }
        protected string Content { get; set; }

        public virtual State HandleSelection(int option)
        {
            
            return GetNextState(option);
        }

        public virtual void ReturnToLastState(int option)
        {
            //DoTransition(option);
        }

        public abstract void DoTransition(int option);
        public abstract State GetNextState(int option);

        public string GetContent()
        {
            return Content;
        }

        public string GetStateContent()
        {
            string str = Content;
            foreach (var s in Options)
            {
                str += s;
            }
            return str;
        }

        /*public void SetOptionsDictionary(string[] keys)
        {
            int i = 1;
            foreach (var s in keys)
            {
                OptionsDictionary.Add(i, s);
                i++;
            }
        }*/

        public int GetOptionCount()
        {
            return Options.Length;
        }

    }
}


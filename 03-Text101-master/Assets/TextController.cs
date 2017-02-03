using StateMachine;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class TextController : MonoBehaviour
    {

        public Text GameText;
        Context gameContext; 

        // Use this for initialization
        void Start()
        {
           gameContext = new Context(new Cell_State());
        }

        // Update is called once per frame
        void Update()
        {
            gameContext.UpdateContext(GameText);
        }
    }
}
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class TextController : MonoBehaviour
    {

        public Text GameText;
        Context gameContext; 
        
        void Start()
        {
           gameContext = new Context(new Cell_State());
        }
        
        void Update()
        {
            gameContext.UpdateContext(GameText);
        }
    }
}
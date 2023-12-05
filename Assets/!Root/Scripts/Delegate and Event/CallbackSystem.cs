using UnityEngine;

namespace LearnVContainer
{
    public class CallbackSystem : MonoBehaviour
    {
        public delegate void OnMessageReceived();

        private static event OnMessageReceived OnComplete;

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                OnComplete?.Invoke();
            } 
        }

        public static void Resgister(OnMessageReceived hid)
        {
            OnComplete += hid;
        }
    }
}

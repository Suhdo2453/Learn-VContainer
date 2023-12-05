using UnityEngine;

namespace LearnVContainer
{
    public class RegistCallBack : MonoBehaviour
    {
        private void Start()
        {
            CallbackSystem.Resgister(DoSomeThing);
        }

        private void DoSomeThing()
        {
            Debug.Log("DoSomething");
        }
    }
}

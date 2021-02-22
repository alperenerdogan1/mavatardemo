using UnityEngine;

public class StateMachineBehaviors : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (stateInfo.IsName("jump"))
        {
            
        }
    }
}
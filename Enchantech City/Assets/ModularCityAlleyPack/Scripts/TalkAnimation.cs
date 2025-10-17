using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkAnimation : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] int repeatNumber;

    int repeatsLeft = 0;

    public void ActivateAnimation ()
    {
        repeatsLeft = repeatNumber;
        animator.SetInteger("Loop", repeatNumber);
        animator.SetTrigger("Talk");
        
    }

    void LoopEvent()
    {
        repeatsLeft--;
        animator.SetInteger("Loop", repeatsLeft);
    }
}

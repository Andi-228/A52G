using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimator : MonoBehaviour
{
    [SerializeField] Animator animator;
    
   
    public void SetGameOverTrigger()
    {
        animator.SetTrigger("GameOver");
    }

    public void SetLevelCompletedTrigger()
    {
        animator.SetTrigger("LevelCompleted");
    }
}


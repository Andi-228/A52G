using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    [SerializeField] ScriptRotator rotator;
    [SerializeField] PinSpawner pinSpawner;
    [SerializeField] CameraAnimator animator;
    // Start is called before the first frame update
    public void GameOver()
    {
        animator.SetGameOverTrigger();
        disableGameElements();
    }

    private void disableGameElements()
    {
        rotator.enabled = false;
        pinSpawner.enabled = false;
    }

    // Update is called once per frame
    private void LevelCompleted()
    {
        animator.SetLevelCompletedTrigger();
        disableGameElements();
    }
}

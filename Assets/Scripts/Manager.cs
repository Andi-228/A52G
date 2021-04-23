using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    [SerializeField] ScriptRotator rotator;
    [SerializeField] PinSpawner pinSpawner;
    [SerializeField] CameraAnimator animator;
    [SerializeField] int numberOfPins;
    private int currentNumberOfPins = 0;

    
    public int GetTotalNumberOfPins()
    {
        return numberOfPins;
    }

    public int GetCurrentNumberOfPins()
    {
        return currentNumberOfPins;
    }
    public void GameOver()
    {
        animator.SetGameOverTrigger();
        disableGameElements();
    }

    public void addPin()
    {
        currentNumberOfPins++;
    }
    private void disableGameElements()
    {
        rotator.enabled = false;
        pinSpawner.enabled = false;
    }

    // Update is called once per frame
    public void LevelCompleted( int sceneIndex)


    {
        disableGameElements();
        int nextLevelIndex = PlayerPrefs.GetInt(Level.NEXT_LEVEL_KEY, Level.LEVEL_TO_START);

        if(sceneIndex >= nextLevelIndex)
        {
            PlayerPrefs.SetInt(Level.NEXT_LEVEL_KEY, sceneIndex + 1);
        }
        animator.SetLevelCompletedTrigger();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimator : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Level level;
   
    public void SetGameOverTrigger()
    {
        animator.SetTrigger("GameOver");
    }

    public void SetLevelCompletedTrigger()
    {
        animator.SetTrigger("LevelCompleted");
    }

    public void LoadLevelCompleteScene()
    {
        int nextSceneIndex = PlayerPrefs.GetInt(Level.NEXT_LEVEL_KEY, Level.LEVEL_TO_START);
        if (nextSceneIndex == level.GetTotalSceneNumber() + 1)
        {
            PlayerPrefs.SetInt(Level.GAME_COMPLETE_KEY, Level.GAME_COMPLETE);
            level.LoadSelectLvlScene();
        }
        else
        {
            level.LoadLvlCompleteScene();
        }
    }

    public void LoadGameoverScene()
    {
        level.LoadLvlFailScene();
    }
}


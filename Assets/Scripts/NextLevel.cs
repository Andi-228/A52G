using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NextLevel : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        int passedSceneIndex = PlayerPrefs.GetInt(
        Level.NEXT_LEVEL_KEY, Level.LEVEL_TO_START);
        text.text = "Next Level " + passedSceneIndex.ToString();
    }

}

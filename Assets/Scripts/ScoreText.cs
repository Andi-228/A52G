using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    private int pinNumber;

    // Start is called before the first frame update
    void Start()
    {
        pinNumber = FindObjectOfType<Manager>()
            .GetTotalNumberOfPins();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = pinNumber.ToString();
    }
    public void ChangeNumberOfPins()
    {
        pinNumber--;
    }
}

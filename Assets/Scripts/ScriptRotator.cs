using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptRotator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float rotatespeed = 100f;
// Update is called once per frame
void Update()
    {
     transform.Rotate(0f, 0f, rotatespeed * Time.deltaTime);
    }
}

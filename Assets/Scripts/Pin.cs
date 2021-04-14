using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    [SerializeField] Rigidbody2D rigidbody;
    private bool isPinned = false;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (isPinned == false)
        {
            rigidbody.MovePosition(rigidbody.position + Vector2.up * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collisionObj)
    {
        if(collisionObj.tag == "Pin")
        {
            FindObjectOfType<Manager>().GameOver();
            Debug.Log("Game Over!");

        }
        else if (collisionObj.tag == "Rotator")
        {
            isPinned = true;
            transform.SetParent(collisionObj.transform);
            FindObjectOfType<ScoreText>().ChangeNumberOfPins();
            Manager manager = FindObjectOfType<Manager>();
            manager.addPin();

            if (manager.GetTotalNumberOfPins() == manager.GetCurrentNumberOfPins())
            {
                manager.LevelCompleted();
            }

        }
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCollision : MonoBehaviour
{   // This script detects whether or not the main camera and the falling object have collided.
    public GameObject game;
    public GameObject mainMenu;
    public GameObject fallingObject;
    public List<GameObject> enemyList = new List<GameObject>();

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Main Camera")
        {
            fallingObject.transform.position = new Vector3(-1f, 100f, 0f);
            game.SetActive(false);
            mainMenu.SetActive(true);
        }
    }

}

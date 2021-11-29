using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCollision : MonoBehaviour
{   // This script detects whether or not the main camera and the falling object have collided.
    public GameObject game;
    public GameObject mainMenu;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Main Camera")
        {
            game.SetActive(false);
            mainMenu.SetActive(true);
        }


    }

}

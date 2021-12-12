using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCollision : MonoBehaviour
{   // This script detects whether or not the main camera and the falling object have collided, and if so, sets the main menu to active.

    public MenuSelection menuSelection;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Main Camera")
        {
            menuSelection.MainMenu();
        }
    }

}

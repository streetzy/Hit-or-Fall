using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCollision : MonoBehaviour 
{
    public static GameObject fallingObject;
    private Vector3 fallObjPosition;
    private Collider fallingObjectCollider;
    // Finds game objects with the tag of falling object and assigns it to fallingObject, then gets its collider and makes its collider ignore other collisions.
    private void Start()
    {
        fallingObject = GameObject.FindGameObjectWithTag("FallingObject");
        fallingObjectCollider = fallingObject.GetComponent<Collider>();

        Physics.IgnoreCollision(fallingObjectCollider, GetComponent<Collider>(), true);
    }

    // Assigning a value to fallObjPosition, then using a switch to increment its value via target's tags, then using that to add to the falling object's y axis. (Destroying game object at the end.)
    void DestroyTarget()
    {
        fallObjPosition = fallingObject.transform.position;

        switch (gameObject.tag)
        {
            case "Large":
                fallObjPosition.y += 15;
                break;
            case "Mid":
                fallObjPosition.y += 30;
                break;
            case "Small":
                fallObjPosition.y += 50;
                break;
        }

        fallingObject.transform.position = new Vector3(0, fallObjPosition.y, 0);

        Destroy(gameObject);
    }
    // On click, calls the destroy target function.
    private void OnMouseDown()
    {
        DestroyTarget();
    }
}

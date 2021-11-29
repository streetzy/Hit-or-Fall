using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCollision : MonoBehaviour 
{
    private GameObject fallingObject;
    private Vector3 fallObjPosition;

    private void Start()
    {
        fallingObject = GameObject.FindGameObjectWithTag("FallingObject");
    }
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

    private void OnMouseDown()
    {
        DestroyTarget();
    }
}

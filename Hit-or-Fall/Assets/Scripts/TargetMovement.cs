using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{

    // Get the rigidbody on the gameObject (in this case: target) and assign its velocity a vector3 with its z axis being updatedSpeed from TargetVelocity.
    private Rigidbody targetRigidbody;
    private void Start()
    {
        targetRigidbody = gameObject.GetComponent<Rigidbody>();
        targetRigidbody.velocity = new Vector3(0, 0, TargetVelocity.updatedSpeed);
    }


    // Update calls OutOfBounds
    private void Update()
    {
        OutOfBounds();
    }

    //If the gameObject's z Axis exceeds -15, it gets destroyed, and the falling object's y position gets lowered.
    private void OutOfBounds()
    {
        if(gameObject.transform.position.z <= -15f)
        {
            Destroy(gameObject);
            TargetCollision.fallingObject.transform.position = new Vector3(0, TargetCollision.fallingObject.transform.position.y - 15, 0);
        }
    }

}

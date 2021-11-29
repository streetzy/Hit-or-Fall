using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    private Rigidbody targetRigidbody;

    private void Start()
    {
        targetRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        targetRigidbody.velocity = new Vector3(0, 0, -5);
        if (gameObject.transform.position.z <= -15f)
        {
            Destroy(gameObject);
        }
    }

    

}

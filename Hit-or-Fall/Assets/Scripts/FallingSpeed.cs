using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSpeed : MonoBehaviour
{
    public Rigidbody fallingObject;
    void Update()
    {
        fallingObject.velocity = new Vector3(0f, -10f, 0f);
    }
}

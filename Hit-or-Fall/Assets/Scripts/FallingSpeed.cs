using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSpeed : MonoBehaviour
{
    // Setting the fallingObject's velocity

    public Rigidbody fallingObjectRigid;
    public MenuSelection menuSelection;

    void Update()
    {
        fallingObjectRigid.velocity = new Vector3(0f, -10f, 0f);
        if (fallingObjectRigid.transform.position.y < 1)
        {
            menuSelection.MainMenu();
        }
    }
}

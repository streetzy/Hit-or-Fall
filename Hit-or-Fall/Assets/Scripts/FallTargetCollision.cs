using UnityEngine;

public class FallTargetCollision : MonoBehaviour
{
    private GameObject fallingObject;
    private Collider fallingObjectCollider;
    void Start()
    {
        fallingObject = GameObject.FindGameObjectWithTag("FallingObject");
        fallingObjectCollider = fallingObject.GetComponent<Collider>();

        Physics.IgnoreCollision(fallingObjectCollider, GetComponent<Collider>(), true);
    }

}

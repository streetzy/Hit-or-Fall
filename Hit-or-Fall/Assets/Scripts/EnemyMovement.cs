using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    private float targetZAxis = 0;
    private Rigidbody targetRigidbody;
    private GameObject target;
    private string targetTag;

    private void Start()
    {
        targetTag = gameObject.tag;

        switch (targetTag)
        {
            case "Large":
                target = GameObject.FindGameObjectWithTag("Large");
                break;
            case "Mid":
                target = GameObject.FindGameObjectWithTag("Mid");
                break;
            case "Small":
                target = GameObject.FindGameObjectWithTag("Small");
                break;
        }
        targetRigidbody = target.GetComponent<Rigidbody>();
        targetRigidbody.velocity = new Vector3(0, 0, -3);
        StartCoroutine(FasterMovement());
    }

    private void Update()
    {
        if (gameObject.transform.position.z <= -15f)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator FasterMovement()
    {
        while (targetZAxis < 10) 
        {
            yield return new WaitForSeconds(2);
            targetZAxis = targetRigidbody.velocity.z;
            targetRigidbody.velocity = new Vector3(0, 0, targetZAxis - 3);
            Debug.Log("Works!");
        }
    }

    //Main idea for this script is to create Target Movement by itself, and then slowly change the vel. over time.

}

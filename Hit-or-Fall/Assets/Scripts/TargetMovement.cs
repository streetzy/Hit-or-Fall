using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    private GameTime gameTime;
    private Rigidbody targetRigidbody;
    private GameObject target;
    private float incrementCoordinate;
    

    private void Start()
    {
        gameTime = GameObject.FindGameObjectWithTag("Game").gameObject.GetComponent<GameTime>();

        target = gameObject;

        targetRigidbody = target.GetComponent<Rigidbody>();
        targetRigidbody.velocity = new Vector3(0, 0, -3);

        incrementCoordinate = 0;
    }

    private void Update()
    {
        if (gameObject.transform.position.z <= -15f)
        {
            Destroy(gameObject);
        }



        if (gameTime.time >= 10 && incrementCoordinate <= -15)
        {
            incrementCoordinate -= 3;
            gameTime.time = 0;
            targetRigidbody.velocity = new Vector3(0, 0, targetRigidbody.velocity.z + incrementCoordinate);
        }
    }

    //Main idea for this script is to create Target Movement by itself, and then slowly change the vel. over time.

}

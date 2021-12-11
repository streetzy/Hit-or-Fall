using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetVelocity : MonoBehaviour
{

    //Declaration
    public GameTime gameTime;
    public static float defaultSpeed;
    public static float updatedSpeed;
    private float perc;

    //Assign a value to defaultSpeed
    void OnEnable()
    {
        defaultSpeed = -3f;
    }

    //perc, percentage is the timer/100, so it works like a percentage. Updated speed is a linear transition from defaultSpeed to -15.
    private void Update()
    {
        perc = gameTime.time / 100;
        updatedSpeed = Mathf.Lerp(defaultSpeed, -15, perc);
    }
}

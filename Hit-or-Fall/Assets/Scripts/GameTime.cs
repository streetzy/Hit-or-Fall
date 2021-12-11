using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime : MonoBehaviour
{
    // Declare time, assign a value to it in OnEnable, and in update, if the gameObject (in this scenario Game) is active, time becomes a timer from when the game started.

    public float time;

    void OnEnable()
    {
        time = 0;
    }

    private void Update()
    {
        if (gameObject.activeInHierarchy)
        {
            time += Time.deltaTime;
        }
    }
}

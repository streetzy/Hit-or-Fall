using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime : MonoBehaviour
{
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

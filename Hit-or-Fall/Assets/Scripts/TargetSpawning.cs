using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawning : MonoBehaviour
{
    private float xAxis;
    private float yAxis;
    private float zAxis;
    public int spawnTime;
    private int randomTarget;
    private Vector3 spawnPosition;
    private List<GameObject> targets = new List<GameObject>();

    public Transform enemyManager;
    public GameObject largeTarget;
    public GameObject target;
    public GameObject smallTarget;

    // Adding targets to the target list, mainly for random target, and then starting a coroutine which spawns targets.
    private void OnEnable()
    {
        targets.Add(largeTarget);
        targets.Add(target);
        targets.Add(smallTarget);
        StartCoroutine(SpawnTargets());
    }

    // Assign random values with specific ranges to positional and time variables.
    void Update()
    {
        xAxis = Random.Range(-4, 5);
        yAxis = Random.Range(2, 6);
        zAxis = Random.Range(-5, 16);
        randomTarget = Random.Range(0, 3);
        spawnPosition = new Vector3(xAxis, yAxis, zAxis);
    }

    // Wait for spawnTime seconds, which has a randomly generated value. Instantiate a random target from the target list, and place it into the Enemy Manager.
    IEnumerator SpawnTargets()
    {
        while (true) 
        {
            yield return new WaitForSeconds(spawnTime);
            Instantiate(targets[randomTarget], spawnPosition, Quaternion.identity, enemyManager);
        }
    }

    
}

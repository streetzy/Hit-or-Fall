using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawning : MonoBehaviour
{
    public int spawnTime;
    public List<GameObject> targets = new List<GameObject>();
   
    public Transform enemyManager;

    // Assign random values with specific ranges to positional and time variables.
    // Wait for spawnTime seconds, which has a randomly generated value. Instantiate a random target from the target list, and place it into the Enemy Manager.
    public IEnumerator SpawnTargets()
    {
        while (true) 
        {
            if (!enemyManager.gameObject.activeInHierarchy) { yield break; }
            yield return new WaitForSeconds(spawnTime);
            Instantiate(targets[Random.Range(0, targets.Count)], new Vector3(Random.Range(-4, 5), Random.Range(2, 6), Random.Range(-5, 16)),  Quaternion.identity, enemyManager);
        }
    }

    
}

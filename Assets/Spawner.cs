using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float spawnRate;
    [SerializeField] private GameObject enemy;
    [SerializeField] private int maxNumberEnemy;
    private bool spawningEnded;
    private List<GameObject> activeEnemies;

    private void Start()
    {
        StartCoroutine(Spawn_CO());
    }

    private void Update()
    {
        if (spawningEnded)
        {
            StartCoroutine(Spawn_CO());
        }
    }

    private IEnumerator Spawn_CO()
    {
        var count = 0;
        while (true)
        {
            activeEnemies.Add(Instantiate(enemy, transform));
            count++;
            yield return new WaitForSeconds(spawnRate);
            if (count >= maxNumberEnemy)
            {
                spawningEnded = true;
                break;
            }
        }
    }
}

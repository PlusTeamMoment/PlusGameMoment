using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float spawnRate;
    [SerializeField] private Enemy enemy;
    [SerializeField] private int maxNumberEnemy;
    private int enemyCount;
    public List<Enemy> activeEnemies;

    private void Start()
    {
        StartCoroutine(Spawn());
    }


    private IEnumerator Spawn()
    {
        while (true)
        {
            if (maxNumberEnemy >= enemyCount)
                continue;

            var obj = Instantiate(enemy, transform.position, Quaternion.identity);
            activeEnemies.Add(obj);
            enemyCount++;
            yield return new WaitForSeconds(spawnRate);
        }
    }

}

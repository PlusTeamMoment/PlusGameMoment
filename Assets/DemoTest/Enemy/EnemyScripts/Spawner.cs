using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float spawnRate;
    [SerializeField] private Enemy enemy;
    [SerializeField] private int maxNumberEnemy;
    private IEnumerator spawner;
    public List<Enemy> activeEnemies;

    private void Start()
    {
        spawner = null;
        StartCoroutine(Spawn());
    }

    private void Update()
    {
        if (activeEnemies.Count < maxNumberEnemy && spawner == null) SpawnerSet();
    }


    private IEnumerator Spawn()
    {
        Vector3 distanceOffset = new Vector3(activeEnemies.Count, 0, 0);
        var obj = Instantiate(enemy, transform.position + distanceOffset, Quaternion.identity);
        obj.transform.SetParent(this.transform);
        activeEnemies.Add(obj);
        yield return new WaitForSeconds(spawnRate);
        SpawnerDetroy();
    }

    void SpawnerSet()
    {
        spawner = Spawn();
        StartCoroutine(spawner);
    }

    void SpawnerDetroy()
    {
        StopCoroutine(spawner);
        spawner = null;
    }

}

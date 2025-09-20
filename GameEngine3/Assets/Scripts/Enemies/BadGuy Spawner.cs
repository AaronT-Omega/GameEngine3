using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuySpawner : EnemySpawner
{
    public GameObject badguyPrefab;
    private void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnDelay, repeatRate);
    }
    public override Enemy SpawnEnemy()
    {
        GameObject createBadguy = Instantiate(badguyPrefab, transform.position, Quaternion.identity);
        return createBadguy.GetComponent<Enemy>();
    }
}

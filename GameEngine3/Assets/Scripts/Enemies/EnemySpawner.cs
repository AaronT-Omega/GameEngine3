using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemySpawner : MonoBehaviour
{

    public float spawnDelay = 5.0f;
    public float repeatRate = 5.0f;


    public abstract Enemy SpawnEnemy();

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FruitSpawner : MonoBehaviour
{
    public float spawnDelay = 5.0f;
    public float repeatRate = 5.0f;

    public Vector3 randomPos;


    public abstract Fruit SpawnFruit();
}

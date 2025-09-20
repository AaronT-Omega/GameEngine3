using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonSpawner : FruitSpawner
{
    public GameObject melonPrefab;
    private void Start()
    {
        InvokeRepeating("SpawnFruit", spawnDelay, repeatRate);
    }
    public override Fruit SpawnFruit()
    {
        GameObject createMelon = Instantiate(melonPrefab, randomPos, Quaternion.identity);
        return createMelon.GetComponent<Fruit>();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] spawnPoints;
    public GameObject[] objectsToSpawn;
    public  float timeRepeatSpawn;
    public float delayToStartSpawm;
    void Start()
    {
        InvokeRepeating("Spawn", delayToStartSpawm, timeRepeatSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Spawn()
    {
        //Debug.Log(Random.Range(0, objectsToSpawn.Length+1));
        Instantiate(objectsToSpawn[Random.Range(0, objectsToSpawn.Length)], (spawnPoints[Random.Range(0, spawnPoints.Length - 1)]));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToSpawn;
    public SpawnObjects spawnContoller;
    public float startTime;
    public float repeatTime;
    void Start()
    {
        InvokeRepeating("SpawnMonster",startTime,repeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnMonster()
    {
        spawnContoller.Spawn(objectToSpawn, transform.position, transform.rotation);
    }
}

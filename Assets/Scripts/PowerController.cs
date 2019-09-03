using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fireball;
    public void SpawnFireball(Transform spawnpoint, Vector3 direction){
        GameObject power = Instantiate(fireball, spawnpoint.position, spawnpoint.rotation);
        power.GetComponent<FireBallMoviment>().direction = direction;
        fireball.gameObject.SetActive(true);
    }
    
}

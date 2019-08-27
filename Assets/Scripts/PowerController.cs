using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fireball;
    public void SpawnFireball(Transform spawnpoint){
        GameObject power = Instantiate(fireball, spawnpoint.position, spawnpoint.rotation);
        fireball.gameObject.SetActive(true);
    }
    
}

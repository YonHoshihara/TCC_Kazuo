using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public string monster_tag; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == monster_tag)
        {
            Debug.Log("Getting Damage");
        }
        yield return new WaitForSeconds(.2f);
    }

    
}

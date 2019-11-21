using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public  string power_tag;
    Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == power_tag)
        {
            //print(col.gameObject.name);
            Debug.Log("Damage in Monster");
            anim.SetTrigger("Damage");
           
            //Destroy(this.gameObject);
        }


    }
}

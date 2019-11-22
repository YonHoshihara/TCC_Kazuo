using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public  string power_tag;
    Animator anim;
    public int life;
    private Golen_atack golen_atack;
    
    IEnumerator Start()
    {
        anim = gameObject.GetComponent<Animator>();
        golen_atack = GetComponent<Golen_atack>();
        yield return new WaitForSeconds(5f);
        anim.SetTrigger("Walk");
        GetComponent<GolenMoviment>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == power_tag)
        {
            life--;
            if(life == 0)
            {
                anim.SetTrigger("Iddle");
                yield return new WaitForSeconds(3f);
                anim.SetTrigger("Die");
                yield return new WaitForSeconds(10f);
                Destroy(gameObject);
            }

           bool is_atack = golen_atack.is_atack;
           if (is_atack)
            {
                anim.SetTrigger("Damage");
                yield return new WaitForSeconds(2f);
                anim.SetTrigger("Atack");
            }
            else{
                GetComponent<GolenMoviment>().enabled = false;
                anim.SetTrigger("Damage");
                yield return new WaitForSeconds(1.5f);
               
                anim.SetTrigger("Walk");
                GetComponent<GolenMoviment>().enabled = true;
            }
           
            
        }
    }
}

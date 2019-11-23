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
    bool is_alive;
    
    IEnumerator Start()
    {
        anim = gameObject.GetComponent<Animator>();
        golen_atack = GetComponent<Golen_atack>();
        yield return new WaitForSeconds(5f);
        anim.SetTrigger("Walk");
        is_alive = true;
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
                GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
                GetComponent<GolenMoviment>().enabled = false;
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
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                GetComponent<GolenMoviment>().enabled = false;
                anim.SetTrigger("Damage");
                yield return new WaitForSeconds(1.5f);
               
                anim.SetTrigger("Walk");
                GetComponent<GolenMoviment>().enabled = true;
            }
           
            
        }
    }

    //Just for gollen
    IEnumerator OnTriggerStay(Collider col)
    {
        Debug.Log("firestorm");
        if (col.gameObject.tag == "firestorm")
        {

            if (is_alive)
            {
                life--;
                
                Debug.Log(life);
                if (life == 0)
                {
                    is_alive = false;
                    anim.SetTrigger("Iddle");
                    GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                    GetComponent<GolenMoviment>().enabled = false;
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
                else
                {
                    anim.SetTrigger("Damage");
                    GetComponent<GolenMoviment>().enabled = false;
                    GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                    yield return new WaitForSeconds(1.05f);
                    anim.SetTrigger("Walk");
                    GetComponent<GolenMoviment>().enabled = true;
                }
            }   
            


        }
    }
}

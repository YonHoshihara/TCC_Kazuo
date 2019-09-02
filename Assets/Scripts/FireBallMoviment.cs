using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallMoviment : MonoBehaviour
{
   float time;
   public float fireSpeed;

     void Start()
    {
        Vector3 force = new Vector3(0,0,1);

        GetComponent<Rigidbody>().AddForce(force);  
    }
    
    //void LateUpdate()
    //{
    //
      //  if (transform.up.y < 0){
        //    transform.position += 1 * transform.up * fireSpeed * Time.deltaTime;
          //  Debug.Log(transform.up);
        //}
        //else
        //{
          //  transform.position += -1 * transform.up * fireSpeed * Time.deltaTime;
        //}
        
        
        //time += Time.deltaTime;
        //if (time > 4) Destroy(gameObject);
    //}


    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.layer != 8)
        {
        	print(col.gameObject.name);
            Destroy(this.gameObject);
        }

    }
}

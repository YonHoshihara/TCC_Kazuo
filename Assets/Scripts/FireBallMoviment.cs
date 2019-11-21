using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallMoviment : MonoBehaviour
{
    float time;
    public float fireSpeed;
    public Vector3 direction;

     void Start()
    {
        GetComponent<Rigidbody>().AddForce(direction * fireSpeed);
    }
     
    public void Shoot()
    {
       
    }
    void LateUpdate()
    {
        //
        //  if (transform.up.y < 0){
        //    transform.position += 1 * transform.up * fireSpeed * Time.deltaTime;
        //  Debug.Log(transform.up);
        //}
        //else
        //{
        //  transform.position += -1 * transform.up * fireSpeed * Time.deltaTime;
        //}


        time += Time.deltaTime;
        if (time > 4) Destroy(gameObject);
    }


     void OnTriggerEnter(Collider col)
    {
       
        if (col.gameObject.tag == "enemy")
        {
        	print(col.gameObject.name);
            Destroy(this.gameObject);
        }
        

    }
}

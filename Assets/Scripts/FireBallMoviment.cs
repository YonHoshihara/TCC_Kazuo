using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallMoviment : MonoBehaviour
{
   float time;
    public float fireSpeed;


    void LateUpdate()
    {

        transform.position += -transform.up * fireSpeed * Time.deltaTime;
       

        time += Time.deltaTime;
        if (time > 4) Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.layer != 8)
        {
        	print(col.gameObject.name);
            Destroy(this.gameObject);
        }

    }
}

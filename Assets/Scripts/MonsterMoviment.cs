﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMoviment : MonoBehaviour
{
    public float speed,time;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 addForceVector;
        addForceVector.x = 0;
        addForceVector.y = 0;
        addForceVector.z = speed;
        gameObject.GetComponent<Rigidbody>().AddForce(addForceVector);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        time += Time.deltaTime;
        if (time > 5) Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golen_atack : MonoBehaviour
{
    // Start is called before the first frame update
    public bool is_atack;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (is_atack)
        {
            anim.SetTrigger("Atack");
        }
      // is_atack = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public string tag;
    public float destroyTime;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == tag)
        {
            yield return new WaitForSeconds(destroyTime);
            Destroy(gameObject);
        }

        yield return new WaitForSeconds(0.0f);
    }
}

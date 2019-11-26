using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{   
    
    // Start is called before the first frame update
    public string SceneName;
    public GameObject fire;
    void Start()
    {
        
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "fireball")
        {
            //  yield return new WaitForSeconds(5f);
                fire.SetActive(true);
                yield return new WaitForSeconds(5f);
                SceneManager.LoadScene(SceneName);         

        }
        yield return new WaitForSeconds(.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

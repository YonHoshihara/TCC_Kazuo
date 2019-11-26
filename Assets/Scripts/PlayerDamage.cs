using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public string monster_tag; 
    public int playerLife;
    public GameObject damage_feedback;
    public GameObject gameOver;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == monster_tag)
        {
          //  yield return new WaitForSeconds(5f);
            playerLife--;
            damage_feedback.SetActive(true);
            //damage_feedback.GetComponent<Image>().material.color = Color.red;
            yield return new WaitForSeconds(2f);
           damage_feedback.SetActive(false);
            Debug.Log("Getting Damage");
            Debug.Log(playerLife);
            if (playerLife < 0)
            {
                gameOver.SetActive(true);
                yield return new WaitForSeconds(5f);
                gameOver.SetActive(false);
                SceneManager.LoadScene("Menu");
            }

        }
        yield return new WaitForSeconds(.2f);
    }

    
}

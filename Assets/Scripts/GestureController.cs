using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureController : MonoBehaviour
{
    // Start is called before the first frame update
        
    public Transform hand;
    Coroutine detectGesture;
    public PowerController powerController;
    void Start()
    {
    
    }
    void OnEnable()
    {
        detectGesture = null;
    }
    // Update is called once per frame
    void Update()
    {
    if(detectGesture == null){
      detectGesture = StartCoroutine(DetectLeftHandGesture());
    } 
   
    }
     IEnumerator DetectLeftHandGesture()  //Detect if the left hand is doing a summoning power gesture.
    {

        float initPos, finalPos;
        initPos = hand.position.z;
       
        yield return new WaitForSeconds(.2F);
        finalPos = hand.position.z;
        
        if ((finalPos - initPos >= .1F)) 
        {
            Debug.Log("FIREEEEEEEEEEEEEEEE!!!");  
            powerController.SpawnFireball(hand);
        }
        detectGesture = null;
    

    }
}

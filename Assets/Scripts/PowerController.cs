using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerController : MonoBehaviour
{
 
    public string currentGesture = " ";
    string lastGesture;
    string stateMachine = "";
    public GameObject fire;
    public GameObject fire2;
    public GameObject fire3;
    public GameObject hand_magic_atack;
    public GameObject hand_magic_defense;
    //public bool is_start_magic = false;
    IEnumerator Start()
    {
        
        while (true)
        {
            if (currentGesture == "CLOSE")
            {
                Debug.Log("Starting Magic");
                StartCoroutine(StartMagic());
                hand_magic_atack.SetActive(true);
                yield return new WaitForSeconds(5f);
                hand_magic_atack.SetActive(false);
                StopCoroutine(StartMagic());
                Debug.Log("Ending_Magic");
            }
            if (currentGesture == "THUMB")
            {
                Debug.Log("Starting Defense");
                hand_magic_defense.SetActive(true);
                StartCoroutine(StartDefense());
                yield return new WaitForSeconds(5f);
                hand_magic_defense.SetActive(false);
                StopCoroutine(StartDefense());
                Debug.Log("Ending_Defense");
            }
            stateMachine = currentGesture;
            yield return new WaitForSeconds(.2F);
        }
    }
    IEnumerator StartMagic()
    {
        while (true)
        {
            string secont_gesture = currentGesture;
            if (secont_gesture == "OPEN")
            {
                hand_magic_atack.SetActive(false);
                fire.SetActive(true);
                Debug.Log("BOLA DE FOGO, METEOOOORO");
                //yield return new WaitForSeconds(.5f);
                break;
                
            }

            if (secont_gesture == "LOVE")
            {
                hand_magic_atack.SetActive(false);
                fire2.SetActive(true);
                Debug.Log("SPIDER MAN");
                //yield return new WaitForSeconds(.5f);
                break;

            }
            yield return new WaitForSeconds(.1f);
        }

    }

    IEnumerator StartDefense()
    {
        while (true)
        {
            string secont_gesture = currentGesture;
            if (secont_gesture == "OPEN")
            {
                hand_magic_defense.SetActive(false);
                Debug.Log("MURALHA DE CRISTAL");
                fire3.SetActive(true);
                //yield return new WaitForSeconds(.5f);
                break;

            }

            if (secont_gesture == "LOVE")
            {

                hand_magic_defense.SetActive(false);
                Debug.Log("VENTO IMPETUOSO");
                //yield return new WaitForSeconds(.5f);
                break;

            }
            yield return new WaitForSeconds(.1f);
        }

    }
}

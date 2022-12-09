using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClassTime : MonoBehaviour
{
    GameObject bt;
    GameObject b;
    void Start()
    {
        
        b = GameObject.Find("LearnButton");
        bt = GameObject.Find("LearnButtonTrue");
        bt.SetActive(false);
        //Debug.Log(Globals.hour);
        if(Globals.hour == 21){
            if(Globals.minute <=1){
               b.SetActive(false);
               bt.SetActive(true);
            }
        }
        else if(Globals.hour == 20){
            if(Globals.minute >=30){
                b.SetActive(false);
                bt.SetActive(true);

            }

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

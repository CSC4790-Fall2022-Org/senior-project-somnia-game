using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassTime : MonoBehaviour
{
    Button b1;
    GameObject b;
    void Start()
    {
        
        b = GameObject.Find("LearnButton");
        b1 = b.GetComponent<Button>();
        

        //Debug.Log(Globals.hour);
        if(Globals.hour == 21){
            if(Globals.minute <=1){
               b1.interactable = true;
            }
        }
        else if(Globals.hour == 20){
            if(Globals.minute >=30){
                b1.interactable = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

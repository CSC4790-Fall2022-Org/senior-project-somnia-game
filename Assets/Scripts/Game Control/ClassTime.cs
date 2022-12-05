using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClassTime : MonoBehaviour
{
    Button b1;
    GameObject b;
    TextMeshProUGUI b2;
    void Start()
    {
        
        b = GameObject.Find("LearnButton");
        b1 = b.GetComponent<Button>();
        b2 = b.GetComponent<TextMeshProUGUI>();

        //Debug.Log(Globals.hour);
        if(Globals.hour == 21){
            if(Globals.minute <=1){
               b1.interactable = true;
               b2.SetText(" ");
            }
        }
        else if(Globals.hour == 20){
            if(Globals.minute >=30){
                b1.interactable = true;
                b2.SetText(" ");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

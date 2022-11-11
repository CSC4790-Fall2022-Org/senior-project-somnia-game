using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuickTimer : MonoBehaviour
{
    public float timeRemaining;
    public TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = 10;
        timerText.SetText("0:10");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            if(timeRemaining<10){
                timerText.SetText("0:0"+(int)timeRemaining);
            }
        }
        else{
            //stuff here
        }
    

    }
}

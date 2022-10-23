using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;
public class timepassage : MonoBehaviour
{
    public int hour;
    public int minute;
    public TextMeshProUGUI leText;
    // Start is called before the first frame update
    void Awake(){
        DontDestroyOnLoad(transform.gameObject);
    }
    void Start()
    {
        hour = 8;
        minute = 0;
    }

    // Update is called once per frame
    void Update()
    {
        String timeText ="";
        if(hour<=12){
            if(minute<10){
                timeText = hour+":0"+minute+ "AM";
        }
            else{
                timeText = hour+":"+minute+" AM";
            }
        }
        else{
            if(minute<10){
                timeText = (hour-12)+":0"+minute+ "PM";
        }
            else{
                timeText = (hour-12)+":"+minute+" PM";
            }
        }
        
        leText.SetText(timeText);

    }
    public void addTime(){
        hour+=1;
        if(hour == 25){
            hour = 0;
        }
    }
}

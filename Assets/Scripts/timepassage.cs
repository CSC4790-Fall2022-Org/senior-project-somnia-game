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
    //void Awake(){
    //    DontDestroyOnLoad(transform.gameObject);
    //}
    void Start()
    {
        hour = 17;
        minute = 0;
    }

    // Update is called once per frame
    void Update()
    {
        string timeText;
        int hourInTwelveHrTime;
        string hourText;
        string minuteText;
        string AMPMText;

        if(hour <= 12)
        {
            hourInTwelveHrTime = hour;
            AMPMText = "AM";
        }
        else
        {
            hourInTwelveHrTime = hour - 12;
            AMPMText = "PM";
        }

        if (hourInTwelveHrTime < 10)
        {
            hourText = "0" + hourInTwelveHrTime;
        }
        else
        {
            hourText = "" + hourInTwelveHrTime;
        }

        if (minute < 10)
        {
            minuteText = "0" + minute;
        }
        else
        {
            minuteText = "" + minute;
        }

        timeText = hourText + ":" + minuteText + " " + AMPMText;
        leText.SetText(timeText);
    }

    public void addTime(){
        hour+=1;
        if(hour == 25){
            hour = 0;
        }
    }
    public void addMins(int mins){
        minute += mins;
        if(minute >= 60){
            minute -= 60;
            hour+=1;
            if(hour == 25){
            hour = 0;
        }
        }
    }

    public string GetCurrentTime()
    {
        return leText.text.ToString();
    }
}

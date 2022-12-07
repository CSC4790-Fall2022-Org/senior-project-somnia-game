using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class timepassage : MonoBehaviour
{
    public int hour;
    public int minute;
    public TextMeshProUGUI leText;
    // Start is called before the first frame update
    //void Awake(){
    //    DontDestroyOnLoad(transform.gameObject);
    //}

    ChangeScene SceneChanger;
    void Start()
    {
        this.hour = Globals.hour;
        this.minute = Globals.minute;

        SceneManager.sceneUnloaded += UpdateGlobalTime;

        SceneChanger = transform.gameObject.GetComponent<ChangeScene>();
    }


    void UpdateGlobalTime(Scene current)
    {
        Globals.hour = this.hour;
        Globals.minute = this.minute;
    }

    // Update is called once per frame
    void Update()
    {
        string timeText;
        int hourInTwelveHrTime;
        string hourText;
        string minuteText;
        string AMPMText;

        if(hour == 0)
        {
            hourInTwelveHrTime = 12;
            AMPMText = "AM";
        }
        else if(hour <= 11)
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
        if(hour == 24)
        {
            Debug.Log("it is midnight!");
            hour = 0;
            EndDay();
        }
    }
    public void addMins(int mins){
        minute += mins;
        if(minute >= 60){
            minute -= 60;
            hour+=1;
            if(hour == 24)
            {
                Debug.Log("it is midnight!");
                hour = 0;
                EndDay();
            }
        }
    }

    public string GetCurrentTime()
    {
        return leText.text.ToString();
    }

    public void EndDay()
    {
        List<GameObject> tasks = GameObject.Find("Tasks").GetComponent<Tasks>().tasks;
        foreach (GameObject task in tasks)
        {
            task.GetComponent<Task>().ShowFailure();
        }
        SceneChanger.SceneTransition(8);
    }
}

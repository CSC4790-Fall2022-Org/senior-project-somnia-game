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
        if(minute<10){
            leText.SetText(hour+":0"+minute);
        }
        else{
            leText.SetText(hour+":"+minute);
        }
    }
    public void addTime(){
        hour+=1;
        if(hour == 13){
            hour = 1;
        }
    }
}

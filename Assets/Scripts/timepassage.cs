using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class timepassage : MonoBehaviour
{
    DateTime time;
    int hour;
    int minute;
    // Start is called before the first frame update
    void Start()
    {
        int hour = 8;
        int minute = 0;
        time = new DateTime(1999,1,1,hour,minute,0);
    }

    // Update is called once per frame
    void Update()
    {
        #clock.sprite = Resources.Load<Sprite>(time.Hour+"oclock.png");

    }
    public void addTime(){
        time.AddHours(1.0);
    }
}

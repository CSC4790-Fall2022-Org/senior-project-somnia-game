using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class timepassage : MonoBehaviour
{
    public DateTime time;
    public int hour;
    public int minute;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        hour = 8;
        minute = 0;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Sprite newSprite = Resources.Load(hour+"oclock", typeof(Sprite)) as Sprite;
        spriteRenderer.sprite = newSprite;
    }
    public void addTime(){
        hour+=1;
        if(hour == 13){
            hour = 1;
        }
    }
}

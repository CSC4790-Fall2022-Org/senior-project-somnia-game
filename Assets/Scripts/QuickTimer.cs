using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuickTimer : MonoBehaviour
{

    public float timeRemaining;
    public TextMeshProUGUI timerText;
    GameObject result;
    QuicktimeResult r1;
    GameObject overlay;
    DefineStats stats;

    // Start is called before the first frame update
    void Start()
    {
        
        timeRemaining = 10;
        timerText.SetText("0:10");
        result = GameObject.Find("QuickTimeResult");
        overlay = GameObject.Find("UIOverlay");
        r1 = result.GetComponent<QuicktimeResult>();
        stats = overlay.GetComponent<DefineStats>();
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
            r1.SetActive();
            r1.setResult("You yourself in front of your peers. Your Stress increased and your happiness decreased!");
            stats.changeHappiness(-10);
            stats.changeStress(20);
            gameObject.SetActive(false);
        }
    

    }
}

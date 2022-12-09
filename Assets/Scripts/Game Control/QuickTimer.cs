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
    AudioSource defaultMusic;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            defaultMusic = GameObject.FindGameObjectWithTag("DefaultMusic").GetComponent<AudioSource>();
        }
        catch(System.NullReferenceException e)
        {
            Debug.Log(e.Message);
            defaultMusic = null;
        }

        if (defaultMusic != null)
        {
            defaultMusic.Pause();
        }
        timeRemaining = 10;
        timerText.SetText("0:10");
        result = GameObject.Find("QuickTimeResult");
        overlay = GameObject.Find("UIOverlay");
        r1 = result.GetComponent<QuicktimeResult>();
        result.SetActive(false);
        stats = overlay.GetComponent<DefineStats>();
    }

    public void PlayDefaultMusic()
    {
        if (defaultMusic != null && !defaultMusic.isPlaying)
        {
            defaultMusic.UnPause();
        }
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
            Debug.Log("you didn't react fast enough");
            r1.SetActive();
            r1.setResult("You embarrass yourself in front of your peers. Your Stress increased and your happiness decreased!");
            stats.changeHappiness(-10);
            stats.changeStress(20);
            gameObject.SetActive(false);
        }
    

    }
}

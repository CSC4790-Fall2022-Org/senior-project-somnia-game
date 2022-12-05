using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class continuebutton : MonoBehaviour
{
    public GameObject butcanvas;
    public AudioClip song;
    float timer = 0f;
 
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > (song.length)) {
            butcanvas.SetActive(true);
        }
    }
}

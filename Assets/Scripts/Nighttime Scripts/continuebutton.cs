using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class continuebutton : MonoBehaviour
{
    public GameObject butcanvas;
    int frames = 0;
 
    // Update is called once per frame
    void Update()
    {
        frames = frames+1;

        if(frames >= 19000) {
            butcanvas.SetActive(true);
        }
    }
}

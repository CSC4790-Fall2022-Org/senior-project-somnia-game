using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSong : MonoBehaviour
{
    public AudioSource oldSong;
    public AudioSource newSong;
    
    void Awake()
    {
        oldSong.Stop();
        newSong.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

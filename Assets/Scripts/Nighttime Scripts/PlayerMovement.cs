using System.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    CharacterController controller;
    Vector2 movement = Vector2.zero;

    public Transform player;
    public KeyCode shiftLeft;
    public KeyCode shiftRight;
    public Transform pos1, pos2, pos3, pos4, pos5;

    public Transform indicator;
    public KeyCode indicator_left;
    public KeyCode indicator_right;
    public KeyCode useZip;
    public Transform in_pos1, in_pos2, in_pos3, in_pos4, in_pos5;
    
    public float speed = 10f;
    int lane = 3;
    int indicator_lane = 3;
    Vector2 playerPosition = new Vector2(-2, -3);
    bool movementBool = false;

    public AudioSource errorSound;
    public AudioSource moveSound;
    public AudioSource hurtSound;
    NightHealthManager HealthManager;
    public float songBpm;
    public float secPerBeat;
    public float songPosition;
    public float songPositionInBeats;
    public float dspSongTime;
    public AudioSource musicSource;

    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        HealthManager = GameObject.Find("NightHealthManager").GetComponent<NightHealthManager>();
        secPerBeat = 60f / songBpm;
        dspSongTime = (float)AudioSettings.dspTime;
    }

    // Update is called once per frame
    void Update()
    {
        checkInput();
        zipControl();
        setMovementBool();
        songPosition = (float)(AudioSettings.dspTime - dspSongTime);
        songPositionInBeats = (int)(songPosition / secPerBeat);
    }

    void setMovementBool()
    {
        if (Math.Abs(songPositionInBeats * secPerBeat - songPosition) <= 0.4)
        {
            movementBool = true;
        }
        else
        {
            movementBool = false;
        }
    }

    void checkInput()
    {
        if (Input.GetKeyDown(shiftLeft) && movementBool)
        {
            Vector3 targetPosition = transform.position;

            if (lane == 2)
            {
                targetPosition.x = pos1.transform.position.x;
                transform.position = targetPosition;
            }

            if (lane == 3)
            {
                targetPosition.x = pos2.transform.position.x;
                transform.position = targetPosition;
            }

            if (lane == 4)
            {
                targetPosition.x = pos3.transform.position.x;
                transform.position = targetPosition;
            }

            if (lane == 5)
            {
                targetPosition.x = pos4.transform.position.x;
                transform.position = targetPosition;
            }

            if (lane > 1)
            {
                lane--;
                moveSound.Play();
            }
        
        }

        if (Input.GetKeyDown(shiftRight) && movementBool)
        {
            Vector3 targetPosition = transform.position;

            if (lane == 1)
            {
                targetPosition.x = pos2.transform.position.x;
                transform.position = targetPosition;
            }

            if (lane == 2)
            {
                targetPosition.x = pos3.transform.position.x;
                transform.position = targetPosition;
            }

            if (lane == 3)
            {
                targetPosition.x = pos4.transform.position.x;
                transform.position = targetPosition;
            }

            if (lane == 4)
            {
                targetPosition.x = pos5.transform.position.x;
                transform.position = targetPosition;
            }

            if (lane < 5)
            {
                lane++;
                moveSound.Play();
            }           
        }
    }

    void zipControl() {

            if (Input.GetKeyDown(indicator_left)){
                Vector3 indicatorTarget = transform.position;

                if (indicator_lane == 2)
                {
                    indicatorTarget = in_pos1.transform.position;
                    indicator.transform.position = indicatorTarget;
                }

                if (indicator_lane == 3)
                {
                    indicatorTarget = in_pos2.transform.position;
                    indicator.transform.position = indicatorTarget;
                }

                if (indicator_lane == 4)
                {
                    indicatorTarget = in_pos3.transform.position;
                    indicator.transform.position = indicatorTarget;
                }

                if (indicator_lane == 5)
                {
                    indicatorTarget = in_pos4.transform.position;
                    indicator.transform.position = indicatorTarget;
                }

                if(indicator_lane > 1)
                {
                    indicator_lane--;
                }
            }

            if (Input.GetKeyDown(indicator_right)) {
                Vector3 indicatorTarget = transform.position;

                if (indicator_lane == 1)
                {
                    indicatorTarget = in_pos2.transform.position;
                    indicator.transform.position = indicatorTarget;
                }

                if (indicator_lane == 2)
                {
                    indicatorTarget = in_pos3.transform.position;
                    indicator.transform.position = indicatorTarget;
                }

                if (indicator_lane == 3)
                {
                    indicatorTarget = in_pos4.transform.position;
                    indicator.transform.position = indicatorTarget;
                }

                if (indicator_lane == 4)
                {
                    indicatorTarget = in_pos5.transform.position;
                    indicator.transform.position = indicatorTarget;
                }

                if(indicator_lane < 5)
                {
                    indicator_lane++;
                }
            }

            if (Input.GetKeyDown(useZip)){
                Vector3 targetPosition = transform.position;

                if (indicator_lane == 1)
                {
                    targetPosition.x = pos1.transform.position.x;
                    transform.position = targetPosition;
                }

                if (indicator_lane == 2)
                {
                    targetPosition.x = pos2.transform.position.x;
                    transform.position = targetPosition;
                }

                if (indicator_lane == 3)
                {
                    targetPosition.x = pos3.transform.position.x;
                    transform.position = targetPosition;
                }

                if (indicator_lane == 4)
                {
                    targetPosition.x = pos4.transform.position.x;
                    transform.position = targetPosition;
                }

                if(indicator_lane == 5)
                {
                    targetPosition.x = pos5.transform.position.x;
                    transform.position = targetPosition;
                }
            }
    }

    void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        //Check for a match with the specified tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag.CompareTo("Fireball") == 0)
        {
            HealthManager.ChangeHealth(-5);
            hurtSound.Play();
            //Log(collision);
        }
    }

    void Log(Collider2D collision, [CallerMemberName] string message = null)
    {
        Debug.Log($"{message} called on {name} because a collision with {collision.gameObject.name}");
    }
}

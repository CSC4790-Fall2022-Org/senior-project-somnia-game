using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    CharacterController controller;
    Vector2 movement = Vector2.zero;
    public KeyCode shiftLeft;
    public KeyCode shiftRight;
    public Transform player;
    public Transform pos1,pos2,pos3,pos4,pos5;
    public float speed = 10f;
    int lane = 3;
    Vector2 playerPosition = new Vector2(-2, -3);
    bool movementBool = false;
    public AudioSource errorSound;
    public AudioSource moveSound;
    NightHealthManager HealthManager;
    public float songBpm;
    public float secPerBeat;
    public float songPosition;
    public float songPositionInBeats;
    public float dspSongTime;
    public AudioSource musicSource;

    // Start is called before the first frame update
    void Start(){
        controller = gameObject.GetComponent<CharacterController> ();
        HealthManager = GameObject.Find("NightHealthManager").GetComponent<NightHealthManager>();
        secPerBeat = 60f / songBpm;
        dspSongTime = (float)AudioSettings.dspTime;
    }

    // Update is called once per frame
    void Update(){
        checkInput();
        setMovementBool();
        songPosition = (float)(AudioSettings.dspTime - dspSongTime);
        songPositionInBeats = (int) (songPosition / secPerBeat);
    }
    void setMovementBool(){ 
        if (songPositionInBeats - (int)songPositionInBeats <= 0.0001){
            movementBool = true;
        }
    }
    void checkInput(){
        if(Input.GetKeyDown(shiftLeft) && movementBool){
            Vector3 targetPosition = transform.position;

            if(lane == 2){
                targetPosition.x = pos1.transform.position.x;
                transform.position = targetPosition;
            }

            if(lane == 3){
                targetPosition.x = pos2.transform.position.x;
                transform.position = targetPosition;
            }

            if(lane == 4){
                targetPosition.x = pos3.transform.position.x;
                transform.position = targetPosition;
            }

            if(lane == 5){
                targetPosition.x = pos4.transform.position.x;
                transform.position = targetPosition;
            }

            if(lane > 1){
                lane--;
                moveSound.Play();
            } else{
                errorSound.Play();
            }
        }
        else{
            errorSound.Play();
        }

        if(Input.GetKeyDown(shiftRight) && movementBool){
            Vector3 targetPosition = transform.position;

            if(lane == 1){
                targetPosition.x = pos2.transform.position.x;
                transform.position = targetPosition;
            }

            if(lane == 2){
                targetPosition.x = pos3.transform.position.x;
                transform.position = targetPosition;
            }

            if(lane == 3){
                targetPosition.x = pos4.transform.position.x;
                transform.position = targetPosition;
            }

            if(lane == 4){
                targetPosition.x = pos5.transform.position.x;
                transform.position = targetPosition;
            }
            
            if(lane < 5){
                lane++;
                moveSound.Play();
            } 
            else{
                errorSound.Play();
            }
        }
        else{
            errorSound.Play();
        }
    }

    void OnTriggerEnter2D(UnityEngine.Collider2D collision){
        //Check for a match with the specified tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag.CompareTo("Fireball") == 0){
            HealthManager.ChangeHealth(-5);
            //Log(collision);
        }
    }

    void Log(Collider2D collision, [CallerMemberName] string message = null){
        Debug.Log($"{message} called on {name} because a collision with {collision.gameObject.name}");
    }
}

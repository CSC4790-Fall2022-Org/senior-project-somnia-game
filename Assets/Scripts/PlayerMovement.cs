using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    CharacterController controller;
    Vector2 movement = Vector2.zero;
    public KeyCode shiftLeft;
    public KeyCode shiftRight;
    public Transform player;
    public Transform pos1,pos2,pos3,pos4,pos5;
    int lane = 3;
    Vector2 playerPosition = new Vector2(-2, -3);
    bool movementBool = true;
    


    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController> ();
    }

    // Update is called once per frame
    void Update()
    {
        checkInput();
    }

    void checkInput()
    {
        if(Input.GetKeyDown(shiftLeft) && movementBool && lane > 1){
            if(lane == 3){
            player.position = pos2.position;
            lane--;
            }

            if(lane == 2){
            player.position = pos1.position;
            lane--;
            }

            if(lane == 4){
            player.position = pos3.position;
            lane--;
            }

            if(lane == 5){
            player.position = pos4.position;
            lane--;
            }

        }
        if(Input.GetKeyDown(shiftRight) && movementBool && lane < 5){
            lane ++;
            movement.x = 3;
        }
    }

    void checkOnBeat()
    {

    }
}

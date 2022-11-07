using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    CharacterController controller;
    Vector2 movement = Vector2.zero;
    public KeyCode shiftLeft;
    public KeyCode shiftRight;
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
            lane --;
            transform.position = new Vector2(-1,-2);
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

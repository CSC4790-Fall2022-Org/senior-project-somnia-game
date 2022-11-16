using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    CharacterController controller;
    int lane = 3;
    Vector3 movement = Vector3.zero;
    bool movementBool = true;


    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void checkInput()
    {
        if(Input.GetKeyDown(KeyCode.A) && movementBool && lane > 1){
            lane --;
            movement.x = -3;
        }
        if(Input.GetKeyDown(KeyCode.D) && movementBool && lane < 5){
            lane ++;
            movement.x = 3;
        }
    }

    void checkOnBeat()
    {

    }
}

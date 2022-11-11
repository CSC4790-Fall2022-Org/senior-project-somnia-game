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
    public float speed = 10f;
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
        if(Input.GetKeyDown(shiftLeft) && movementBool){
            Vector3 targetPosition = transform.position;

            if(lane == 2){
                targetPosition.x = pos1.transform.position.x;
                transform.position = targetPosition;
                Debug.Log("Lane 1");
            }

            if(lane == 3){
                targetPosition.x = pos2.transform.position.x;
                transform.position = targetPosition;
                Debug.Log("Lane 2");
            }

            if(lane == 4){
                targetPosition.x = pos3.transform.position.x;
                transform.position = targetPosition;
                Debug.Log("Lane 3");
            }

            if(lane == 5){
                targetPosition.x = pos4.transform.position.x;
                transform.position = targetPosition;
                Debug.Log("Lane 4");
            }

            if(lane > 1){
            lane--;
            }
        }

        if(Input.GetKeyDown(shiftRight) && movementBool){
            Vector3 targetPosition = transform.position;

            if(lane == 1){
                targetPosition.x = pos2.transform.position.x;
                transform.position = targetPosition;
                Debug.Log("Lane 2");
            }

            if(lane == 2){
                targetPosition.x = pos3.transform.position.x;
                transform.position = targetPosition;
                Debug.Log("Lane 3");
            }

            if(lane == 3){
                targetPosition.x = pos4.transform.position.x;
                transform.position = targetPosition;
                Debug.Log("Lane 4");
            }

            if(lane == 4){
                targetPosition.x = pos5.transform.position.x;
                transform.position = targetPosition;
                Debug.Log("Lane 5");
            }
            
            if(lane < 5){
            lane++;
            }
        }
    }

    void checkOnBeat()
    {

    }
}

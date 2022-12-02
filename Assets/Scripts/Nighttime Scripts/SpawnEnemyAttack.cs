using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyAttack : MonoBehaviour
{
    public float spawnTimer = 0.75f;
    public static Transform pos1, pos2, pos3, pos4, pos5;
    public static Transform[] positions = new Transform[] {pos1, pos2, pos3, pos4, pos5};
    public GameObject fireball;
    Vector3 fireballTargetPosition;

    // Start is called before the first frame update
    void Start()
    {
        fireballTargetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //This method of spawning prefabs was found in the following unity forum
        //https://answers.unity.com/questions/637597/instantiate-at-intervals.html
        spawnTimer -= Time.deltaTime;

        if(spawnTimer <= 0){
            // fireballTargetPosition.x = pos1.transform.position.x;
            // Instantiate(fireball, fireballTargetPosition, Quaternion.identity);
            // spawnTimer = 0.75f;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyAttack : MonoBehaviour
{
    public float spawnTimer = 0.75f;
    public static Transform pos1, pos2, pos3, pos4, pos5;
    public Transform[] positions = new Transform[] {pos1, pos2, pos3, pos4, pos5};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // spawnTimer -= time.deltaTime;
    }
}

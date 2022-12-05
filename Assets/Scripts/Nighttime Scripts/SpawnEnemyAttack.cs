using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyAttack : MonoBehaviour
{
    private const float timeBetweenAttacks = 1.2f;
    public float spawnTimer = timeBetweenAttacks;
    public GameObject fireball;
    Vector3 fireballTargetPosition;
    int index;

    Vector3 pos1 = new Vector3(-5.0f,6.0f,0.0f);
    Vector3 pos2 = new Vector3(-2.5f,6.0f,0.0f);
    Vector3 pos3 = new Vector3(0.0f,6.0f,0.0f);
    Vector3 pos4 = new Vector3(2.5f,6.0f,0.0f);
    Vector3 pos5 = new Vector3(5.0f,6.0f,0.0f);
    Vector3[] positions;

    // Start is called before the first frame update
    void Start()
    {
        positions = new [] {pos1, pos2, pos3, pos4, pos5};
        fireballTargetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //This method of spawning prefabs was found in the following unity forum
        //https://answers.unity.com/questions/637597/instantiate-at-intervals.html
        spawnTimer -= Time.deltaTime;

        if(spawnTimer <= 0){
            index = Random.Range(0, positions.Length);
            fireballTargetPosition = positions[index];
            Instantiate(fireball, fireballTargetPosition, Quaternion.identity);
            spawnTimer = timeBetweenAttacks;
        }
    }

    // private void OnBecameInvisible() {
    //     Debug.Log("Destroyed");
    // }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsManager : MonoBehaviour
{
    NightHealthManager HealthManager;
    public GameObject veins;
    SpawnEnemyAttack EnemyAttackSpawner;

    // Start is called before the first frame update
    void Start()
    {
        EnemyAttackSpawner = GameObject.Find("EnemyAttackSpawner").GetComponent<SpawnEnemyAttack>();
        HealthManager = GameObject.Find("NightHealthManager").GetComponent<NightHealthManager>();

        if (HealthManager.GetHealth() < 80)
        {
            SetVeinsVisible(true);
        }
        if (Globals.happiness < 50)
        {
            SetFireballGravity(2f);
            SetFireballInterval(0.6f);
        }
        else
        {
            SetFireballGravity(0.25f);
            SetFireballInterval(1.2f);
        }
        if (Globals.stress > 50)
        {
            SetFireballMaxNumberToSpawnAtOnce(2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetVeinsVisible(bool isVisible)
    {
        // set veins to be visible
        veins.SetActive(true);
    }

    public void SetFireballGravity(float gravity)
    {
        GameObject fireball = EnemyAttackSpawner.fireball;
        Rigidbody2D fireballRigidBody = fireball.transform.GetChild(0).GetComponent<Rigidbody2D>();
        fireballRigidBody.gravityScale = gravity;
    }

    public void SetFireballInterval(float interval)
    {
        EnemyAttackSpawner.timeBetweenAttacks = interval;
    }

    public void SetFireballMaxNumberToSpawnAtOnce(int number)
    {
        EnemyAttackSpawner.maxNumberToSpawnAtOnce = number;
}
}

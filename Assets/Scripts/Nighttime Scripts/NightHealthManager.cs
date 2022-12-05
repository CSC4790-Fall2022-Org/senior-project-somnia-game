using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NightHealthManager : MonoBehaviour
{

    public TextMeshProUGUI HealthText;
    private int health;

    // Start is called before the first frame update
    void Start()
    {
        SetHealthText();
    }

    // Update is called once per frame
    void Update()
    {
        SetHealthText();
    }

    // Used for both increase and decrease
    // decrease = negative input
    // increase = positive input
    public void ChangeHealth(int change)
    {
        health += change;
        if(health > 100)
        {
            health = 100;
        }
        if(health < 0)
        {
            health = 0;
        }
    }

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int health)
    {
        this.health = health;
        if (health > 100)
        {
            health = 100;
        }
        if (health < 0)
        {
            health = 0;
        }
    }

    private void SetHealthText()
    {
        HealthText.text = health + "";
    }
}

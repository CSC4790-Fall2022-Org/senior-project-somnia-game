using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NightHealthManager : MonoBehaviour
{

    public TextMeshProUGUI HealthText;
    private int health = 100;
    public AudioSource endSound;

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
        if(health == 0) {
            health = 0;
            endSound.Play();
            SceneManager.LoadScene(11);

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

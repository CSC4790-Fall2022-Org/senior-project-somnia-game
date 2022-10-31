using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedArrow : MonoBehaviour
{
    public SpriteRenderer arrow;

    public object SetActive { get; private set; }

    private Vector2 STATS_POSITION = new Vector2(-5.45F, 3.5F);
    private Vector2 ENERGY_POSITION = new Vector2(-5.7F, 3.9F);
    private Vector2 HAPPY_POSITION = new Vector2(-5.7F, 3.5F);
    private Vector2 STRESS_POSITION = new Vector2(-5.7F, 3.1F);
    private Vector2 CLOCK_POSITION = new Vector2(-6.1F, 4.45F);

    public void pointTo(Vector2 position)
    {
        transform.position = position;
    }

    public void pointToDormButton()
    {
        
    }

    public void pointToStats()
    {
        transform.localScale = new Vector2(1.8F, 1.8F);
        pointTo(STATS_POSITION);
    }

    public void pointToEnergy()
    {
        transform.localScale = new Vector2(1.2F, 1.2F);
        pointTo(ENERGY_POSITION);
    }

    public void pointToHappiness()
    {
        transform.localScale = new Vector2(1.2F, 1.2F);
        pointTo(HAPPY_POSITION);
    }

    public void pointToStress()
    {
        transform.localScale = new Vector2(1.2F, 1.2F);
        pointTo(STRESS_POSITION);
    }

    public void pointToClock()
    {
        transform.localScale = new Vector2(1.2F, 1.2F);
        pointTo(CLOCK_POSITION);
    }

    public void hide()
    {
        gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        transform.localScale = new Vector2(60, 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedArrow : MonoBehaviour
{
    public SpriteRenderer arrow;

    public object SetActive { get; private set; }

    public void pointToDormButton()
    {
        
    }

    public void pointToStats()
    {
        transform.localScale = new Vector2(60, 60);
        transform.position = new Vector2(155, 388);
    }

    public void pointToEnergy()
    {
        transform.localScale = new Vector2(40, 40);
        transform.position = new Vector2(130, 404);
    }

    public void pointToHappiness()
    {
        transform.localScale = new Vector2(40, 40);
        transform.position = new Vector2(130, 387);
    }

    public void pointToStress()
    {
        transform.localScale = new Vector2(40, 40);
        transform.position = new Vector2(130, 370);
    }

    public void pointToClock()
    {
        transform.localScale = new Vector2(40, 40);
        transform.position = new Vector2(120, 430);
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

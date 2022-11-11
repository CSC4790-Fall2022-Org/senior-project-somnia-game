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
    private Vector2 CLOCK_POSITION = new Vector2(-5.7F, 4.45F);
    private Vector2 TASKS_POSITION = new Vector2(-7.15F, 1.8F);

    private Vector2 MED_SCALE = new Vector2(1.2F, 1.2F);
    private Vector2 LARGE_SCALE = new Vector2(1.8F, 1.8F);

    private Vector3 LEFT = new Vector3(0F, 0F, 0F);
    private Vector3 DOWN = new Vector3(0F, 0F, 90F);
    private Vector3 RIGHT = new Vector3(0F, 0F, 180F);

    public void PointTo(Vector2 position)
    {
        transform.position = position;
    }

    public void SetScale(Vector2 scale)
    {
        transform.localScale = scale;
    }

    public void PointInDirection(Vector3 direction)
    {
        transform.localEulerAngles = direction;
    }

    public void PointToDormButton()
    {
        PointInDirection(DOWN);
        SetScale(LARGE_SCALE);
        PointTo(new Vector2(-1F, 3.5F));
    }

    public void PointToStats()
    {
        SetScale(LARGE_SCALE);
        PointTo(STATS_POSITION);
        PointInDirection(LEFT);
    }

    public void PointToEnergy()
    {
        SetScale(MED_SCALE);
        PointTo(ENERGY_POSITION);
        PointInDirection(LEFT);
    }

    public void PointToHappiness()
    {
        SetScale(MED_SCALE);
        PointTo(HAPPY_POSITION);
        PointInDirection(LEFT);
    }

    public void PointToStress()
    {
        SetScale(MED_SCALE);
        PointTo(STRESS_POSITION);
        PointInDirection(LEFT);
    }

    public void PointToClock()
    {
        SetScale(MED_SCALE);
        PointTo(CLOCK_POSITION);
        PointInDirection(LEFT);
    }

    public void PointToTasksButton()
    {
        SetScale(MED_SCALE);
        PointTo(TASKS_POSITION);
        PointInDirection(DOWN);
    }

    public void PointToFirstTaskDescription()
    {
        PointTo(new Vector2(-1.7F, 3.5F));
        SetScale(MED_SCALE);
        PointInDirection(RIGHT);
    }

    public void PointToFirstTaskDeadline()
    {
        PointTo(new Vector2(-1.45F, 3F));
        SetScale(MED_SCALE);
        PointInDirection(RIGHT);
    }

    public void PointToSecondTaskDescription()
    {
        PointTo(new Vector2(-1.7F, 2.5F));
        SetScale(MED_SCALE);
        PointInDirection(RIGHT);
    }

    public void Hide()
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

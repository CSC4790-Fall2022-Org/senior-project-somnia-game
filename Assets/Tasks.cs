using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tasks : MonoBehaviour
{
    public GameObject TaskPrefab;
    public GameObject[] tasks = new GameObject[10];

    const int Y_SPACE_BETWEEN_TASKS = 45;
    Vector2 INITIAL_POSITION = new Vector2(129, 155);

    bool isVisible = false;
    public void toggleVisibility()
    {
        if (isVisible)
        {
            transform.localScale = new Vector2(0, 0);
        }
        else
        {
            transform.localScale = new Vector2(1, 1);
        }

        isVisible = !isVisible;
    }

    public void addTask(string desc, string time)
    {
        
    }

    public void checkTasks()
    {

    }

    public void showTaskOverdue(int taskNumber)
    {

    }

    public void showTaskDone(int taskNumber)
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector2(0, 0);
        isVisible = false;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

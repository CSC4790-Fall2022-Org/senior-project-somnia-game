using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tasks : MonoBehaviour
{
    public GameObject TaskPrefab;
    public GameObject[] tasks = new GameObject[10];

    Transform childCanvas;
    int numTasks = 0;

    const int Y_SPACE_BETWEEN_TASKS = 45;
    Vector2 INITIAL_POSITION = new Vector2(129, 155);

    public void show()
    {
        transform.localScale = new Vector2(1, 1);
    }

    public void hide()
    {
        transform.localScale = new Vector2(0, 0);
    }

    public Vector2 getNextTaskPosition()
    {
        float nextPositionX = INITIAL_POSITION.x;
        float nextPositionY = INITIAL_POSITION.y - (numTasks * Y_SPACE_BETWEEN_TASKS);

        Vector2 nextPosition = new Vector2(nextPositionX, nextPositionY);

        return nextPosition;
    }

    public void addTask(string description)
    {
        Vector2 nextPosition = getNextTaskPosition();
        GameObject newTask;
        newTask = Instantiate(TaskPrefab, new Vector2(0,0), Quaternion.identity);
        newTask.transform.SetParent(childCanvas, false);
        newTask.transform.localPosition = nextPosition;

        newTask.GetComponent<Task>().setDescriptionAndTime(description);

        tasks[numTasks] = newTask;
        numTasks++;

        Debug.Log("Task added with description " + description);
        Debug.Log("Current tasks: " + tasks);
    }

    public void checkTasks()
    {

    }

    public void showTaskOverdue(int taskNumber)
    {
        if(numTasks >= taskNumber + 1)
        {
            GameObject taskToFail = tasks[taskNumber];
            taskToFail.GetComponent<Task>().showFailure();
        }
        else
        {
            Debug.Log("No task to fail");
        }
    }

    public void showTaskDone(int taskNumber)
    {
        if(numTasks >= taskNumber + 1)
        {
            GameObject taskToComplete = tasks[taskNumber];
            taskToComplete.GetComponent<Task>().showCompletion();
        }
        else
        {
            Debug.Log("No task to complete");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        hide();
        childCanvas = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

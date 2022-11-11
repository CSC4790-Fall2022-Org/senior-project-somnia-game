using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tasks : MonoBehaviour
{
    public GameObject TaskPrefab;
    public List<GameObject> tasks = new List<GameObject>();

    Transform childCanvas;

    const int Y_SPACE_BETWEEN_TASKS = 45;
    Vector2 INITIAL_POSITION = new Vector2(129, 155);

    public void Show()
    {
        transform.localScale = new Vector2(1, 1);
    }

    public void Hide()
    {
        transform.localScale = new Vector2(0, 0);
    }

    public Vector2 GetNextTaskPosition()
    {
        float nextPositionX = INITIAL_POSITION.x;
        float nextPositionY = INITIAL_POSITION.y - (tasks.Count * Y_SPACE_BETWEEN_TASKS);

        Vector2 nextPosition = new Vector2(nextPositionX, nextPositionY);

        return nextPosition;
    }

    public void AddTask(string description)
    {
        Vector2 nextPosition = GetNextTaskPosition();
        GameObject newTask;
        newTask = Instantiate(TaskPrefab, new Vector2(0,0), Quaternion.identity);
        newTask.transform.SetParent(childCanvas, false);
        newTask.transform.localPosition = nextPosition;

        newTask.GetComponent<Task>().SetDescriptionAndTime(description, "2:00PM");

        tasks.Add(newTask);

        Debug.Log("Task added with description " + description);
        Debug.Log("Current tasks: " + tasks);
    }

    public void CheckTasks()
    {

    }

    public void ShowTaskOverdue(int taskNumber)
    {
        if(tasks.Count >= taskNumber + 1)
        {
            GameObject taskToFail = tasks[taskNumber];
            taskToFail.GetComponent<Task>().ShowFailure();
        }
        else
        {
            Debug.Log("No task to fail");
        }
    }

    public void ShowTaskDone(int taskNumber)
    {
        if(tasks.Count >= taskNumber + 1)
        {
            GameObject taskToComplete = tasks[taskNumber];
            taskToComplete.GetComponent<Task>().ShowCompletion();
        }
        else
        {
            Debug.Log("No task to complete");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Hide();
        childCanvas = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Tasks : MonoBehaviour
{
    public GameObject TaskPrefab;
    public List<GameObject> tasks = new List<GameObject>(5);

    Transform childCanvas;

    const int Y_SPACE_BETWEEN_TASKS = 45;
    Vector2 INITIAL_POSITION = new Vector2(129, 155);

    Dictionary<int, Dictionary<string, string>> allTasks = new Dictionary<int, Dictionary<string, string>>
    {
        {
            0,
            new Dictionary<string,string>
            {
                {"description", "Check emails" },
                {"time", "08:00 PM" }
            }
        },
        {
            1,
            new Dictionary<string, string>
            {
                {"description", "Watch the sunset" },
                {"time", "06:00 PM" }
            }
        }
    };

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

    public void AddTask(int id)
    {
        Vector2 nextPosition = GetNextTaskPosition();
        GameObject newTask;
        newTask = Instantiate(TaskPrefab, new Vector2(0,0), Quaternion.identity);
        newTask.transform.SetParent(childCanvas, false);
        newTask.transform.localPosition = nextPosition;

        string description = allTasks[id]["description"];
        string time = allTasks[id]["time"];
        newTask.GetComponent<Task>().SetUp(id, description, time);

        tasks.Add(newTask);

        Debug.Log("Task added with description " + description);
        Debug.Log("Current tasks: " + tasks.ToString());
    }

    public void CheckTasks()
    {
        GameObject UIOverlay = GameObject.Find("UIOverlay");
        if(tasks.Count > 0)
        {
            foreach (GameObject task in tasks)
            {
                string rawCurrTime = UIOverlay.GetComponent<timepassage>().GetCurrentTime();
                System.DateTime currTime = System.DateTime.ParseExact(rawCurrTime, "hh:mm tt", CultureInfo.CurrentCulture);
                System.DateTime deadline = task.GetComponent<Task>().GetDeadline();
                if (currTime > deadline)
                {
                    task.GetComponent<Task>().ShowFailure();
                }
            }
        }
    }

    public void ShowTaskOverdue(int index)
    {
        if(tasks.Count >= index + 1)
        {
            GameObject taskToFail = tasks[index];
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

        AddTask(0);
        AddTask(1);
    }

    // Update is called once per frame
    void Update()
    {
        CheckTasks();
    }
}

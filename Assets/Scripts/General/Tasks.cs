using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void AddTask(int id)
    {
        GameObject newTask;
        newTask = Instantiate(TaskPrefab, new Vector2(0,0), Quaternion.identity);

        string description = Globals.allTasks[id]["description"];
        string time = Globals.allTasks[id]["time"];
        newTask.GetComponent<Task>().SetUp(id, description, time);

        RenderTask(newTask);
        tasks.Add(newTask);
    }

    public void RenderTask(GameObject task)
    {
        Vector2 nextPosition = GetNextTaskPosition();

        task.transform.SetParent(childCanvas, false);
        task.transform.localPosition = nextPosition;
    }


    public Vector2 GetNextTaskPosition()
    {
        float nextPositionX = INITIAL_POSITION.x;
        float nextPositionY = INITIAL_POSITION.y - (tasks.Count * Y_SPACE_BETWEEN_TASKS);

        Vector2 nextPosition = new Vector2(nextPositionX, nextPositionY);

        return nextPosition;
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

    public void OnDisable()
    {
        if(this.tasks.Count > 0)
        {
            foreach (GameObject task in this.tasks)
            {
                task.transform.SetParent(null, false);
                DontDestroyOnLoad(task);
            }
            Globals.tasks = this.tasks;
            Debug.Log("Updating global tasks");
        }
    }

    public void GetExistingTasks()
    {
        foreach (GameObject task in Globals.tasks)
        {
            RenderTask(task);
            this.tasks.Add(task);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Hide();
        childCanvas = transform.GetChild(0);

        if(Globals.tasks.Count == 0)
        {
            Debug.Log("there are no existing tasks");
            AddTask(0);
            AddTask(1);
        }
        else
        {
            Debug.Log("there are existing tasks");
            GetExistingTasks();
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckTasks();
    }
}

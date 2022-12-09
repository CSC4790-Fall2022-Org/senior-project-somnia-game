using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Task : MonoBehaviour
{
    public TextMeshProUGUI taskDescriptionAndTime;
    public enum Status {pending, completed, failed};
    Status CurrStatus = Status.pending;
    public int id;
    public string description;
    public int decrease_stress;
    public int increase_stress;
    public System.DateTime deadline;

    DefineStats stats;

    public void SetUp(int id, string description, string time, int decrease_stress, int increase_stress)
    {
        this.id = id;
        this.description = description;
        this.deadline = System.DateTime.ParseExact(time, "hh:mm tt", CultureInfo.CurrentCulture);
        this.decrease_stress = decrease_stress;
        this.increase_stress = increase_stress;
        taskDescriptionAndTime.text = description + "\n" + time;
    }

    public System.DateTime GetDeadline()
    {
        return this.deadline;
    }

    private void Strikethrough()
    {
        taskDescriptionAndTime.fontStyle = FontStyles.Strikethrough;
    }

    private void SetColor(Color color)
    {
        taskDescriptionAndTime.color = color;
    }

    public void ShowFailure()
    {
        if(CurrStatus == Status.pending)
        {
            Strikethrough();
            Color slightlyFadedRed = new(182f/255f, 77f/255f, 77f/255f);
            SetColor(slightlyFadedRed);
            CurrStatus = Status.failed;
            stats = GameObject.Find("UIOverlay").GetComponent<DefineStats>();
            stats.changeStress(increase_stress);
            Debug.Log("You failed to complete a task on time");
        }
    }

    public void ShowCompletion()
    {
        if(CurrStatus != Status.failed)
        { 
            Strikethrough();
            SetColor(Color.gray);

            GameObject checkmark = transform.GetChild(2).gameObject;
            checkmark.SetActive(true);

            CurrStatus = Status.completed;
            stats = GameObject.Find("UIOverlay").GetComponent<DefineStats>();
            stats.changeStress(-decrease_stress);
        }
    }

    //public void OnDisable()
    //{
    //    Debug.Log("don't destroy me!");
    //    //transform.SetParent(null, false);
    //    transform.parent = null;
    //    DontDestroyOnLoad(gameObject);
    //}

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}

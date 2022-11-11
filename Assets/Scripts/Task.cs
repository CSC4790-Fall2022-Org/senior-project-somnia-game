using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using TMPro;

public class Task : MonoBehaviour
{
    public TextMeshProUGUI taskDescriptionAndTime;
    public enum Status {pending, completed, failed};
    Status CurrStatus = Status.pending;
    public int id;
    public string description;
    public System.DateTime deadline;

    public void SetUp(int id, string description, string time)
    {
        this.id = id;
        this.description = description;
        this.deadline = System.DateTime.ParseExact(time, "hh:mm tt", CultureInfo.CurrentCulture);
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
        if(CurrStatus != Status.completed)
        {
            Strikethrough();
            Color slightlyFadedRed = new(182f/255f, 77f/255f, 77f/255f);
            SetColor(slightlyFadedRed);
            CurrStatus = Status.failed;
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
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Task : MonoBehaviour
{
    public TextMeshProUGUI taskDescriptionAndTime;
    public enum Status {pending, completed, failed};
    Status currStatus = Status.pending;

    public void setDescriptionAndTime(string description)
    {
        string time = "2:00PM";
        taskDescriptionAndTime.text = description + "\n" + time;
    }

    private void strikethrough()
    {
        taskDescriptionAndTime.fontStyle = FontStyles.Strikethrough;
    }

    private void setColor(Color color)
    {
        taskDescriptionAndTime.color = color;
    }

    public void showFailure()
    {
        if(currStatus != Status.completed)
        {
            strikethrough();
            Color slightlyFadedRed = new(182f/255f, 77f/255f, 77f/255f);
            setColor(slightlyFadedRed);
        }
    }

    public void showCompletion()
    {
        if(currStatus != Status.failed)
        { 
            strikethrough();
            setColor(Color.gray);

            GameObject checkmark = transform.GetChild(2).gameObject;
            checkmark.SetActive(true);
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

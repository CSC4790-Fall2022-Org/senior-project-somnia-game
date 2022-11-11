using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Task : MonoBehaviour
{
    public TextMeshProUGUI taskDescriptionAndTime;
    public enum Status {pending, completed, failed};
    Status currStatus = Status.pending;

    public void SetDescriptionAndTime(string description, string time)
    {
        taskDescriptionAndTime.text = description + "\n" + time;
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
        if(currStatus != Status.completed)
        {
            Strikethrough();
            Color slightlyFadedRed = new(182f/255f, 77f/255f, 77f/255f);
            SetColor(slightlyFadedRed);
        }
    }

    public void ShowCompletion()
    {
        if(currStatus != Status.failed)
        { 
            Strikethrough();
            SetColor(Color.gray);

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

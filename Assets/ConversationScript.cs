using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ConversationScript : MonoBehaviour
{
    public NPCConversation conversationWithSmoochy;

    void StartConversation(NPCConversation conversation)
    {
        ConversationManager.Instance.StartConversation(conversation);
    }

    void SetConversationBool(string boolName, bool input)
    {
        ConversationManager.Instance.SetBool(boolName, input);
    }

    bool GetConversationBool(string boolName)
    {
        return ConversationManager.Instance.GetBool(boolName);
    }

    void SetConversationInt(string intName, int input)
    {
        ConversationManager.Instance.SetInt(intName, input);
    }

    int GetConversationInt(string intName)
    {
        return ConversationManager.Instance.GetInt(intName);
    }

    void RollForDeath()
    {
        int coinFlip = Random.Range(0, 2);
        SetConversationInt("deathRoll", coinFlip);
        Debug.Log("You rolled " + GetConversationInt("deathRoll"));
    }

    // Start is called before the first frame update
    void Start()
    {
        StartConversation(conversationWithSmoochy);
        RollForDeath();
    }

    // Update is called once per frame
    void Update()
    {
        if(GetConversationBool("restart") == true)
        {
            StartConversation(conversationWithSmoochy);
            RollForDeath();
            SetConversationBool("restart", false);
        }
    }
}

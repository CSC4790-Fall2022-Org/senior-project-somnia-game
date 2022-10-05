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

    // Start is called before the first frame update
    void Start()
    {
        StartConversation(conversationWithSmoochy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

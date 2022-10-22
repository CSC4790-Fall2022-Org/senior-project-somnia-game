using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DayTutorialMapScript : MonoBehaviour
{
    public NPCConversation TutorialConversation;

    // Start is called before the first frame update
    void Start()
    {
        ConversationManager.Instance.StartConversation(TutorialConversation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

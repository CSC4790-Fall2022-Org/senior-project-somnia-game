using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DayTutorialScript : MonoBehaviour
{
    public NPCConversation TutorialConversation;

    public void FinishTutorial()
    {
        Globals.tutorialDone = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        if(!Globals.tutorialDone)
        {
            ConversationManager.Instance.StartConversation(TutorialConversation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

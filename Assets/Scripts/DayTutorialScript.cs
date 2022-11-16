using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DayTutorialScript : MonoBehaviour
{
    public NPCConversation TutorialConversation;
    private GameObject redArrow;

    private void Awake()
    {
        redArrow = GameObject.Find("RedArrow");
}

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

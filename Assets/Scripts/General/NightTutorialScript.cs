using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class NightTutorialScript : MonoBehaviour
{
    public NPCConversation conversation;
    GameObject defaultMusic;

    // Start is called before the first frame update
    void Start()
    {
        defaultMusic = GameObject.FindGameObjectWithTag("DefaultMusic");
        if (defaultMusic != null)
        {
            Destroy(defaultMusic);
        }
        ConversationManager.Instance.StartConversation(conversation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

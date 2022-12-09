using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class GenericConvoScript : MonoBehaviour
{
    public NPCConversation Dialogue;


    // Start is called before the first frame update
    void Start()
    {
        ConversationManager.Instance.StartConversation(Dialogue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

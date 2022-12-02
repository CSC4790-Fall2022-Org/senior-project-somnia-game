using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DayTutorialScript : MonoBehaviour
{
    public NPCConversation CurrentConversation;
    Scene scene;

    public void FinishTutorial()
    {
        Globals.tutorialDone = true;
        GameObject MapButton = GameObject.Find("MapButton");
        MapButton.GetComponent<Button>().onClick.RemoveAllListeners();
        MapButton.GetComponent<Button>().onClick.AddListener(() => MapButton.GetComponent<ChangeScene>().SceneTransition(4));
        Debug.Log("End the tutorial");
    }

    public void MoveToNextTutorialPhase(int phase)
    {
        Globals.tutorialPhase = phase;
        if (Globals.tutorialPhase > 3)
        {
            Globals.tutorialPhase = 0;
            CurrentConversation = null;
        }
    }

    public void EndQuickTimeTutorial()
    {
        NPCConversation next = GameObject.Find("TutorialConversation2").GetComponent<NPCConversation>();
        ConversationManager.Instance.StartConversation(next);
    }

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        if (scene.name.Equals("DayTutorialMap"))
        {
            switch (Globals.tutorialPhase)
            {
                case 1:
                    CurrentConversation = GameObject.Find("TutorialMapConversation1").GetComponent<NPCConversation>();
                    MoveToNextTutorialPhase(2);
                    break;
                case 2:
                    CurrentConversation = GameObject.Find("TutorialMapConversation2").GetComponent<NPCConversation>();
                    MoveToNextTutorialPhase(3);
                    break;
                case 3:
                    CurrentConversation = GameObject.Find("TutorialMapConversation3").GetComponent<NPCConversation>();
                    break;
                default:
                    CurrentConversation = null;
                    break;

            } 
        }

        if (!Globals.tutorialDone && CurrentConversation != null)
        {
            GameObject MapButton = GameObject.Find("MapButton");
            MapButton.GetComponent<Button>().onClick.RemoveAllListeners();
            MapButton.GetComponent<Button>().onClick.AddListener(() => MapButton.GetComponent<ChangeScene>().SceneTransition(2));
            ConversationManager.Instance.StartConversation(CurrentConversation);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

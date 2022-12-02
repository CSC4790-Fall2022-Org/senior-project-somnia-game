using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ChanceManager : MonoBehaviour
{
    public int Roll100()
    {
        // max is exclusive
        int roll = Random.Range(1, 101);
        Debug.Log("rolled " + roll);
        return roll;
    }

    public int CoinFlip()
    {
        int flip = Random.Range(1, 3);
        Debug.Log("flipped " + flip);
        return flip;
    }

    public void Roll100ForDialogue()
    {
        ConversationManager.Instance.SetInt("roll", Roll100());
    }

    public void CoinFlipForDialogue()
    {
        ConversationManager.Instance.SetInt("coinflip", CoinFlip());
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

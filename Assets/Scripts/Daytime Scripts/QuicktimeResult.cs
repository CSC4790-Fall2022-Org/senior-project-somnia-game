using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DialogueEditor;

public class QuicktimeResult : MonoBehaviour
{
    public TextMeshProUGUI enText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setResult(string result){
        enText.SetText(result);
    }
    public void SetActive(){
        gameObject.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefineStats : MonoBehaviour
{

    public int stress;
    public int hunger;
    public int happiness;
    public int energy;
    //stats are on a scale of 0-100

    // Start is called before the first frame update
    void Start()
    {
        stress = 20;
        hunger = 40;
        happiness = 50;
        energy = 90;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

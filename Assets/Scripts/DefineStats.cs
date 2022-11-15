using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DefineStats : MonoBehaviour
{

    public int stress;
    public int happiness;
    public int energy;
    public TextMeshProUGUI enText;
    //stats are on a scale of 0-100

    // void Awake(){
    //     DontDestroyOnLoad(transform.gameObject);
    // }
    
    // Start is called before the first frame update
    void Start()
    {
        this.energy = Globals.energy;
        this.stress = Globals.stress;
        this.happiness = Globals.happiness;

        SceneManager.sceneUnloaded += UpdateGlobalStats;
    }

   public void changeStress(int num){
        stress += num;
        if(stress > 100){
            stress = 100;
        }
        else if(stress <0){
            stress = 0;
        }
    }
   public void changeEnergy(int num){
        energy += num;
        if(energy > 100){
            energy = 100;
        }
        else if(energy <0){
            energy = 0;
        }
    }
    public void changeHappiness(int num){
        happiness += num;
        if(happiness > 100){
            happiness = 100;
        }
        else if(happiness <0){
            happiness = 0;
        }
    }
    public int getStress(){
        return stress;
    }
    public int getEnergy(){
        return energy;
    }
    public int getHappiness(){
        return happiness;
    }

    public void UpdateGlobalStats(Scene current)
    {
        Globals.energy = this.energy;
        Globals.stress = this.stress;
        Globals.happiness = this.happiness;
    }

    // Update is called once per frame
    void Update()
    {
        enText.SetText("Energy: " + energy+"\nHappy:  "+happiness+"\nStress: "+stress);
    }
}

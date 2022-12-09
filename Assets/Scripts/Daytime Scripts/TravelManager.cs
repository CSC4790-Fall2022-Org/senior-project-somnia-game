using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TravelManager : MonoBehaviour
{
    public DefineStats StatsManager;
    public timepassage TimeManager;

    public Button dormButton;
    public Button cafeteriaButton;
    public Button libraryButton;
    public Button classroomButton;

    public void GoToLocation(Globals.Location destination)
    {
        StatsManager.changeEnergy(Globals.mapCosts[Globals.CurrLocation][destination]["energy"]);
        TimeManager.addMins(Globals.mapCosts[Globals.CurrLocation][destination]["time"]);
        Globals.CurrLocation = destination;

    }

    // Start is called before the first frame update
    void Start()
    {
        if(dormButton != null) dormButton.onClick.AddListener(() => GoToLocation(Globals.Location.Dorm));
        if(cafeteriaButton != null) cafeteriaButton.onClick.AddListener(() => GoToLocation(Globals.Location.Cafeteria));
        if(libraryButton != null) libraryButton.onClick.AddListener(() => GoToLocation(Globals.Location.Library));
        if(classroomButton != null) classroomButton.onClick.AddListener(() => GoToLocation(Globals.Location.Classroom));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

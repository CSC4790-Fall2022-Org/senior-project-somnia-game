using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour
{
    public static Globals Instance;

    // stats
    public static int energy = 90;
    public static int stress = 40;
    public static int happiness = 60;

    // time
    public static int hour = 17;
    public static int minute = 0;

    public static bool tutorialDone = false;
    public static int tutorialPhase = 1;

    public static Dictionary<int, Dictionary<string, string>> allTasks = new Dictionary<int, Dictionary<string, string>>
    {
        {
            0,
            new Dictionary<string,string>
            {
                {"description", "Check emails" },
                {"time", "08:00 PM" },
                {"decrease_stress", "5" },
                {"increase_stress", "5" }
            }
        },
        {
            1,
            new Dictionary<string, string>
            {
                {"description", "Watch the sunset" },
                {"time", "06:00 PM" },
                {"decrease_stress", "0" },
                {"increase_stress", "0" }
            }
        },
        {
            2,
            new Dictionary<string, string>
            {
                {"description", "Go to class" },
                {"time", "09:15 PM" },
                {"decrease_stress", "10" },
                {"increase_stress", "20" }
            }
        }
    };

    public static List<GameObject> tasks = new List<GameObject>();

    /*
     *  From:
     *      To:
     *          time cost:
     *          energy cost:
     */

    public enum Location { Dorm, Cafeteria, Library, Classroom };
    public static Location CurrLocation = Location.Dorm;

    public static Dictionary<Location, Dictionary<Location, Dictionary<string, int>>> mapCosts = new()
    {
        {
            Location.Dorm,
            new Dictionary<Location, Dictionary<string, int>>
            {
                {
                    Location.Dorm,
                    new Dictionary<string, int>
                    {
                        { "time", 0 },
                        { "energy", 0 },
                    }
                },
                {
                    Location.Cafeteria,
                    new Dictionary<string, int>
                    {
                        { "time", 5 },
                        { "energy", -1 },
                    }
                },
                {
                    Location.Library,
                    new Dictionary<string, int>
                    {
                        { "time", 10 },
                        { "energy", -2 },
                    }
                },
                {
                    Location.Classroom,
                    new Dictionary<string, int>
                    {
                        { "time", 15 },
                        { "energy", -3 },
                    }
                },
            }
        },
        {
            Location.Cafeteria,
            new Dictionary<Location, Dictionary<string, int>>
            {
                {
                    Location.Dorm,
                    new Dictionary<string, int>
                    {
                        { "time", 5 },
                        { "energy", -1 },
                    }
                },
                {
                    Location.Cafeteria,
                    new Dictionary<string, int>
                    {
                        { "time", 0 },
                        { "energy", 0 },
                    }
                },
                {
                    Location.Library,
                    new Dictionary<string, int>
                    {
                        { "time", 15 },
                        { "energy", -3 },
                    }
                },
                {
                    Location.Classroom,
                    new Dictionary<string, int>
                    {
                        { "time", 10 },
                        { "energy", -2 },
                    }
                },
            }
        },
        {
            Location.Library,
            new Dictionary<Location, Dictionary<string, int>>
            {
                {
                    Location.Dorm,
                    new Dictionary<string, int>
                    {
                        { "time", 10 },
                        { "energy", -2 },
                    }
                },
                {
                    Location.Cafeteria,
                    new Dictionary<string, int>
                    {
                        { "time", 15 },
                        { "energy", -3 },
                    }
                },
                {
                    Location.Library,
                    new Dictionary<string, int>
                    {
                        { "time", 0 },
                        { "energy", 0 },
                    }
                },
                {
                    Location.Classroom,
                    new Dictionary<string, int>
                    {
                        { "time", 5 },
                        { "energy", -1 },
                    }
                },
            }
        },
        {
            Location.Classroom,
            new Dictionary<Location, Dictionary<string, int>>
            {
                {
                    Location.Dorm,
                    new Dictionary<string, int>
                    {
                        { "time", 15 },
                        { "energy", -3 },
                    }
                },
                {
                    Location.Cafeteria,
                    new Dictionary<string, int>
                    {
                        { "time", 10 },
                        { "energy", -2 },
                    }
                },
                {
                    Location.Library,
                    new Dictionary<string, int>
                    {
                        { "time", 5 },
                        { "energy", -1 },
                    }
                },
                {
                    Location.Classroom,
                    new Dictionary<string, int>
                    {
                        { "time", 0 },
                        { "energy", 0 },
                    }
                },
            }
        },
    };

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
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

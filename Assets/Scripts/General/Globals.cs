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
                {"time", "08:00 PM" }
            }
        },
        {
            1,
            new Dictionary<string, string>
            {
                {"description", "Watch the sunset" },
                {"time", "06:00 PM" }
            }
        },
        {
            2,
            new Dictionary<string, string>
            {
                {"description", "Go to class" },
                {"time", "09:00 PM" }
            }
        }
    };

    public static List<GameObject> tasks = new List<GameObject>();

    /*
        Dorm:
	        Cafeteria:
		        time: 5,
		        energy: 1
	        Library: 
		        time: 10,
		        energy: 2
	        Classroom: 
		        time: 15,
		        energy: 3
        Cafeteria:
	        Dorm: 
		        time: 5,
		        energy: 1
	        Library: 
		        time: 15,
		        energy: 3
	        Classroom: 
		        time: 10,
		        energy: 2
        Library:
	        Dorm: 
		        time: 10,
		        energy: 2
	        Cafeteria: 
		        time: 15,
		        energy: 3
	        Classroom: 
		        time: 5,
		        energy: 1
        Classroom:
	        Dorm: 
		        time: 15,
		        energy: 3
	        Cafeteria: 
		        time: 10,
		        energy: 2
	        Library: 
		        time: 5,
		        energy: 1
    */

    public static Dictionary<string, Dictionary<string, Dictionary<string, int>>> mapCosts = new()
    {
        {
            "Dorm",
            new Dictionary<string, Dictionary<string, int>>
            {
                {
                    "Cafeteria",
                    new Dictionary<string, int>
                    {
                        { "time", 5 },
                        { "energy", 1 },
                    }
                },
                {
                    "Library",
                    new Dictionary<string, int>
                    {
                        { "time", 10 },
                        { "energy", 2 },
                    }
                },
                {
                    "Classroom",
                    new Dictionary<string, int>
                    {
                        { "time", 15 },
                        { "energy", 3 },
                    }
                },
            }
        },
        {
            "Cafeteria",
            new Dictionary<string, Dictionary<string, int>>
            {
                {
                    "Dorm",
                    new Dictionary<string, int>
                    {
                        { "time", 5 },
                        { "energy", 1 },
                    }
                },
                {
                    "Library",
                    new Dictionary<string, int>
                    {
                        { "time", 15 },
                        { "energy", 3 },
                    }
                },
                {
                    "Classroom",
                    new Dictionary<string, int>
                    {
                        { "time", 10 },
                        { "energy", 2 },
                    }
                },
            }
        },
        {
            "Library",
            new Dictionary<string, Dictionary<string, int>>
            {
                {
                    "Dorm",
                    new Dictionary<string, int>
                    {
                        { "time", 10 },
                        { "energy", 2 },
                    }
                },
                {
                    "Cafeteria",
                    new Dictionary<string, int>
                    {
                        { "time", 15 },
                        { "energy", 3 },
                    }
                },
                {
                    "Classroom",
                    new Dictionary<string, int>
                    {
                        { "time", 5 },
                        { "energy", 1 },
                    }
                },
            }
        },
        {
            "Classroom",
            new Dictionary<string, Dictionary<string, int>>
            {
                {
                    "Dorm",
                    new Dictionary<string, int>
                    {
                        { "time", 15 },
                        { "energy", 3 },
                    }
                },
                {
                    "Cafeteria",
                    new Dictionary<string, int>
                    {
                        { "time", 10 },
                        { "energy", 2 },
                    }
                },
                {
                    "Library",
                    new Dictionary<string, int>
                    {
                        { "time", 5 },
                        { "energy", 1 },
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

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
        }
    };

    public static List<GameObject> tasks = new List<GameObject>();

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

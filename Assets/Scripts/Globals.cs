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

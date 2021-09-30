using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvilScript : MonoBehaviour
{
    GameObject Resources;
    public float TimerMaxTime;
    public float TimerCurrentTime;
    void Start()
    {
        Resources = GameObject.FindGameObjectWithTag("ResourceController");
        Resources.GetComponent<ResourceController>().Building += 1;
        TimerCurrentTime = TimerMaxTime;
    }

    
    void Update()
    {
        TimerCurrentTime -= Time.deltaTime;
        if (TimerCurrentTime <= 0)
        {
            if (Resources.GetComponent<ResourceController>().Gold >= 200 && Resources.GetComponent<ResourceController>().Wood >= 50 && Resources.GetComponent<ResourceController>().Stone >= 100)
            {
                Resources.GetComponent<ResourceController>().Weapons += 1;
                Resources.GetComponent<ResourceController>().Gold -= 200;
                Resources.GetComponent<ResourceController>().Wood -= 50;
                Resources.GetComponent<ResourceController>().Stone -= 100;
            }
            
            TimerCurrentTime = TimerMaxTime;
        }
    }
}

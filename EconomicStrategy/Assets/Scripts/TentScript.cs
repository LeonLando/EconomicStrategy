using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentScript : MonoBehaviour
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
            Resources.GetComponent<ResourceController>().Gold += Resources.GetComponent<ResourceController>().Resident * 10;
            TimerCurrentTime = TimerMaxTime;
        }
    }
}

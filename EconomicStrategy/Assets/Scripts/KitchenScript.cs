﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenScript : MonoBehaviour
{
    GameObject Resources;
    public float TimerMaxTime;
    public float TimerCurrentTime;
    void Start()
    {
        Resources = GameObject.FindGameObjectWithTag("ResourceController");
        Resources.GetComponent<ResourceController>().Building += 1;
        Resources.GetComponent<ResourceController>().ResidentsHaveFood = true;
        TimerCurrentTime = TimerMaxTime;
    }

    
    void Update()
    {
        TimerCurrentTime -= Time.deltaTime;
        if (TimerCurrentTime <= 0)
        {
            Resources.GetComponent<ResourceController>().Food -= Resources.GetComponent<ResourceController>().Resident * 2;
            TimerCurrentTime = TimerMaxTime;
        }
    }
}

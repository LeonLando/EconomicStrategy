﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleScript : MonoBehaviour
{
    GameObject Resources;
    public int AdditionalWood;
    public int AdditionalStone;
    public int AdditionalFood;
    void Start()
    {
        Resources = GameObject.FindGameObjectWithTag("ResourceController");
        Resources.GetComponent<ResourceController>().Resident += 1;
        Resources.GetComponent<ResourceController>().MaxResident += 1;
        Resources.GetComponent<ResourceController>().Building += 1;
        Resources.GetComponent<ResourceController>().MaxWood += AdditionalWood;
        Resources.GetComponent<ResourceController>().MaxStone += AdditionalStone;
        Resources.GetComponent<ResourceController>().MaxFood += AdditionalFood;
    }

    
    void Update()
    {
        
    }
}

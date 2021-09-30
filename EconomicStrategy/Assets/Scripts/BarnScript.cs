using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarnScript : MonoBehaviour
{
    public int AdditionalWood;
    public int AdditionalStone;
    public int AdditionalFood;
    GameObject Resources;

    void Start()
    {
        Resources = GameObject.FindGameObjectWithTag("ResourceController");
        Resources.GetComponent<ResourceController>().MaxWood += AdditionalWood;
        Resources.GetComponent<ResourceController>().MaxStone += AdditionalStone;
        Resources.GetComponent<ResourceController>().MaxFood += AdditionalFood;
        Resources.GetComponent<ResourceController>().Building += 1;
    }

   
}

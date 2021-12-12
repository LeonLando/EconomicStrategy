using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleScript : MonoBehaviour
{
    ResourceController Resources;
    public int AdditionalWood;
    public int AdditionalStone;
    public int AdditionalFood;
    public float MaxTime;
    public float CurrentTime;
    void Start()
    {
        Resources = GameObject.FindGameObjectWithTag("ResourceController").GetComponent<ResourceController>();
        Resources.Resident += 10;
        Resources.MaxResident += 20;
        Resources.Building += 1;
        Resources.MaxWood += AdditionalWood;
        Resources.MaxStone += AdditionalStone;
        Resources.MaxFood += AdditionalFood;
    }

    
    void Update()
    {
        CurrentTime -= Time.deltaTime;
        if (CurrentTime <= 0)
        {
            Resources.Food += 2;
            CurrentTime = MaxTime;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleScript : MonoBehaviour
{
    GameObject Resources;
    void Start()
    {
        Resources = GameObject.FindGameObjectWithTag("ResourceController");
        Resources.GetComponent<ResourceController>().Resident += 1;
        Resources.GetComponent<ResourceController>().MaxResident += 1;
        Resources.GetComponent<ResourceController>().Building += 1;
    }

    
    void Update()
    {
        
    }
}

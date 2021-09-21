using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildManager : MonoBehaviour
{
    public bool BuiltBy;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        if (BuiltBy == true)
        {
            transform.GetChild(0).GetComponent<Image>().color = Color.red;
        }
        else
        {
            transform.GetChild(0).GetComponent<Image>().color = Color.green;
        }
        
    }

    void OnMouseExit()
    {
        transform.GetChild(0).GetComponent<Image>().color = Color.white;
    }
}

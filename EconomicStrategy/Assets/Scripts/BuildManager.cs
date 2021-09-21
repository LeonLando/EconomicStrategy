using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildManager : MonoBehaviour
{
    public bool BuiltBy;
    public GameObject ShopPanel;
    public bool Water;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (ShopPanel.active)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && transform.GetChild(0).GetComponent<Image>().color == Color.green)
        {
            if (Water == false)
            {
                ShopPanel.SetActive(true);
            }
        }
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

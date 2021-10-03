using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildManager : MonoBehaviour
{
    public GameObject ShopPanel;
    public bool Flag;
    public bool Water;
    public bool ActiveCell;
    public bool Building;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (ShopPanel.active)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && (transform.GetChild(0).GetComponent<Image>().color == Color.green || transform.GetChild(0).GetComponent<Image>().color == Color.yellow))
        {
            if (Water == false)
            {
                ShopPanel.SetActive(true);
                ActiveCell = true;
            }
        }
    }

    void OnMouseEnter()
    {
        if (ShopPanel.active)
        {
            return;
        }
        else
        {

            if ((Building == true && Flag == true) || Water == true)
            {
                transform.GetChild(0).GetComponent<Image>().color = Color.red;
            }
            else if (Building == true)
            {
                transform.GetChild(0).GetComponent<Image>().color = Color.yellow;
            }
            else
            {
                transform.GetChild(0).GetComponent<Image>().color = Color.green;
            }
        }
      
        
    }

    void OnMouseExit()
    {
        transform.GetChild(0).GetComponent<Image>().color = Color.white;
    }

    public void SetBuild(GameObject build)
    {
        Instantiate(build).transform.position = transform.GetChild(1).transform.position;
        Building = true;
        ActiveCell = false;
    }
    public void SetBuildFlag(GameObject build)
    {
        Instantiate(build).transform.position = transform.GetChild(2).transform.position;
        Building = true;
        ActiveCell = false;
    }
}

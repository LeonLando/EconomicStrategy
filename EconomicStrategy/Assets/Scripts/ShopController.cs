using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    [Header("Building")]
    public GameObject Castle;
    public GameObject Barn;
    public GameObject Envil;
    public GameObject Farm;
    public GameObject House;
    public GameObject Kitchen;
    public GameObject Mine;
    public GameObject Tent;
    public GameObject Tower;
    public GameObject Well;
    [Header("Other")]
    [SerializeField] private GameObject ShopPanel;
    [SerializeField] private GameObject AllCell;
    public bool CastleBuild;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void Cancel()
    {
        ShopPanel.SetActive(false);
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell = true;
                break;
            }
        }
    }

    public void BuildCastle()
    {
        if (CastleBuild == true)
        {
            return;
        }
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Castle);
                CastleBuild = true;
                break;
            }
        }
        ShopPanel.SetActive(false);
    }

    public void BuildBarn()
    {
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Barn);
                break;
            }
        }
        ShopPanel.SetActive(false);
    }

    public void BuildEnvil()
    {
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Envil);
                break;
            }
        }
        ShopPanel.SetActive(false);
    }

    public void BuildFarm()
    {
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Farm);
                break;
            }
        }
        ShopPanel.SetActive(false);
    }

    public void BuildHouse()
    {
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(House);
                break;
            }
        }
        ShopPanel.SetActive(false);
    }

    public void BuildKitchen()
    {
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Kitchen);
                break;
            }
        }
        ShopPanel.SetActive(false);
    }

    public void BuildMine()
    {
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Mine);
                break;
            }
        }
        ShopPanel.SetActive(false);
    }

    public void BuildTent()
    {
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Tent);
                break;
            }
        }
        ShopPanel.SetActive(false);
    }

    public void BuildTower()
    {
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Tower);
                break;
            }
        }
        ShopPanel.SetActive(false);
    }

    public void BuildWell()
    {
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Well);
                break;
            }
        }
        ShopPanel.SetActive(false);
    }
    
}

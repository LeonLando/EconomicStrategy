using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    [SerializeField] private GameObject ResoursePanel;
    public bool CastleBuild;
    [Header("ErrorMessage")]
    [SerializeField] private GameObject ErrorResourses;
    [SerializeField] private GameObject ErrorCastle;
    [Header("BuildPriceCastle")]
    public int GoldPriceCastle;
    public int WoodPriceCastle;
    public int StonePriceCastle;
    public Text GoldTextCastle;
    public Text WoodTextCastle;
    public Text StoneTextCastle;
    [Header("BuildPriceTower")]
    public int GoldPriceTower;
    public int WoodPriceTower;
    public int StonePriceTower;
    public Text GoldTextTower;
    public Text WoodTextTower;
    public Text StoneTextTower;
    [Header("BuildPriceFarm")]
    public int GoldPriceFarm;
    public int WoodPriceFarm;
    public int StonePriceFarm;
    public Text GoldTextFarm;
    public Text WoodTextFarm;
    public Text StoneTextFarm;
    [Header("BuildPriceMine")]
    public int GoldPriceMine;
    public int WoodPriceMine;
    public int StonePriceMine;
    public Text GoldTextMine;
    public Text WoodTextMine;
    public Text StoneTextMine;
    [Header("BuildPriceHouse")]
    public int GoldPriceHouse;
    public int WoodPriceHouse;
    public int StonePriceHouse;
    public Text GoldTextHouse;
    public Text WoodTextHouse;
    public Text StoneTextHouse;
    [Header("BuildPriceTent")]
    public int GoldPriceTent;
    public int WoodPriceTent;
    public int StonePriceTent;
    public Text GoldTextTent;
    public Text WoodTextTent;
    public Text StoneTextTent;
    [Header("BuildPriceBarn")]
    public int GoldPriceBarn;
    public int WoodPriceBarn;
    public int StonePriceBarn;
    public Text GoldTextBarn;
    public Text WoodTextBarn;
    public Text StoneTextBarn;
    [Header("BuildPriceWell")]
    public int GoldPriceWell;
    public int WoodPriceWell;
    public int StonePriceWell;
    public Text GoldTextWell;
    public Text WoodTextWell;
    public Text StoneTextWell;
    [Header("BuildPriceEnvil")]
    public int GoldPriceEnvil;
    public int WoodPriceEnvil;
    public int StonePriceEnvil;
    public Text GoldTextEnvil;
    public Text WoodTextEnvil;
    public Text StoneTextEnvil;
    [Header("BuildPriceKitchen")]
    public int GoldPriceKitchen;
    public int WoodPriceKitchen;
    public int StonePriceKitchen;
    public Text GoldTextKitchen;
    public Text WoodTextKitchen;
    public Text StoneTextKitchen;

    void Start()
    {
        
    }

   
    void Update()
    {
        GoldTextCastle.text = GoldPriceCastle.ToString();
        WoodTextCastle.text = WoodPriceCastle.ToString();
        StoneTextCastle.text = StonePriceCastle.ToString();
    }

    public void Cancel()
    {
        ErrorCastle.SetActive(false);
        ErrorResourses.SetActive(false);
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
            ErrorCastle.SetActive(true);
            return;
        }
        if (ResoursePanel.GetComponent<ResourseController>().Gold < GoldPriceCastle || ResoursePanel.GetComponent<ResourseController>().Wood < WoodPriceCastle || ResoursePanel.GetComponent<ResourseController>().Stone < StonePriceCastle)
        {
            ErrorResourses.SetActive(true);
            return;
        }
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Castle);
                CastleBuild = true;
                ResoursePanel.GetComponent<ResourseController>().Gold -= GoldPriceCastle;
                ResoursePanel.GetComponent<ResourseController>().Wood -= WoodPriceCastle;
                ResoursePanel.GetComponent<ResourseController>().Stone -= StonePriceCastle;
                break;
            }
        }
        Cancel();
    }

    public void BuildBarn()
    {
        if (ResoursePanel.GetComponent<ResourseController>().Gold < 5000)
        {
            ErrorResourses.SetActive(true);
            return;
        }
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Barn);
                ResoursePanel.GetComponent<ResourseController>().Gold -= GoldPriceBarn;
                ResoursePanel.GetComponent<ResourseController>().Wood -= WoodPriceBarn;
                ResoursePanel.GetComponent<ResourseController>().Stone -= StonePriceBarn;
                break;
            }
        }
        Cancel();
    }

    public void BuildEnvil()
    {
        if (ResoursePanel.GetComponent<ResourseController>().Gold < 5000)
        {
            ErrorResourses.SetActive(true);
            return;
        }
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Envil);
                ResoursePanel.GetComponent<ResourseController>().Gold -= GoldPriceEnvil;
                ResoursePanel.GetComponent<ResourseController>().Wood -= WoodPriceEnvil;
                ResoursePanel.GetComponent<ResourseController>().Stone -= StonePriceEnvil;
                break;
            }
        }
        Cancel();
    }

    public void BuildFarm()
    {
        if (ResoursePanel.GetComponent<ResourseController>().Gold < 1500)
        {
            ErrorResourses.SetActive(true);
            return;
        }
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Farm);
                ResoursePanel.GetComponent<ResourseController>().Gold -= GoldPriceFarm;
                ResoursePanel.GetComponent<ResourseController>().Wood -= WoodPriceFarm;
                ResoursePanel.GetComponent<ResourseController>().Stone -= StonePriceFarm;
                break;
            }
        }
        Cancel();
    }

    public void BuildHouse()
    {
        if (ResoursePanel.GetComponent<ResourseController>().Gold < 2000)
        {
            ErrorResourses.SetActive(true);
            return;
        }
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(House);
                ResoursePanel.GetComponent<ResourseController>().Gold -= GoldPriceHouse;
                ResoursePanel.GetComponent<ResourseController>().Wood -= WoodPriceHouse;
                ResoursePanel.GetComponent<ResourseController>().Stone -= StonePriceHouse;
                break;
            }
        }
        Cancel();
    }

    public void BuildKitchen()
    {
        if (ResoursePanel.GetComponent<ResourseController>().Gold < 4500)
        {
            ErrorResourses.SetActive(true);
            return;
        }
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Kitchen);
                ResoursePanel.GetComponent<ResourseController>().Gold -= GoldPriceKitchen;
                ResoursePanel.GetComponent<ResourseController>().Wood -= WoodPriceKitchen;
                ResoursePanel.GetComponent<ResourseController>().Stone -= StonePriceKitchen;
                break;
            }
        }
        Cancel(); 
    }

    public void BuildMine()
    {
        if (ResoursePanel.GetComponent<ResourseController>().Gold < 3000)
        {
            ErrorResourses.SetActive(true);
            return;
        }
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Mine);
                ResoursePanel.GetComponent<ResourseController>().Gold -= GoldPriceMine;
                ResoursePanel.GetComponent<ResourseController>().Wood -= WoodPriceMine;
                ResoursePanel.GetComponent<ResourseController>().Stone -= StonePriceMine;
                break;
            }
        }
        Cancel();
    }

    public void BuildTent()
    {
        if (ResoursePanel.GetComponent<ResourseController>().Gold < 500)
        {
            ErrorResourses.SetActive(true);
            return;
        }
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Tent);
                ResoursePanel.GetComponent<ResourseController>().Gold -= GoldPriceTent;
                ResoursePanel.GetComponent<ResourseController>().Wood -= WoodPriceTent;
                ResoursePanel.GetComponent<ResourseController>().Stone -= StonePriceTent;
                break;
            }
        }
        Cancel();
    }

    public void BuildTower()
    {
        if (ResoursePanel.GetComponent<ResourseController>().Gold < 5000) //Особый план
        {
            ErrorResourses.SetActive(true);
            return;
        }
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Tower);
                ResoursePanel.GetComponent<ResourseController>().Gold -= GoldPriceTower;
                ResoursePanel.GetComponent<ResourseController>().Wood -= WoodPriceTower;
                ResoursePanel.GetComponent<ResourseController>().Stone -= StonePriceTower;
                break;
            }
        }
        Cancel();
    }

    public void BuildWell()
    {
        if (ResoursePanel.GetComponent<ResourseController>().Gold < 300)
        {
            ErrorResourses.SetActive(true);
            return;
        }
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Well);
                ResoursePanel.GetComponent<ResourseController>().Gold -= GoldPriceWell;
                ResoursePanel.GetComponent<ResourseController>().Wood -= WoodPriceWell;
                ResoursePanel.GetComponent<ResourseController>().Stone -= StonePriceWell;
                break;
            }
        }
        Cancel();
    }

    
}

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
    public GameObject Saw;
    [Header("Other")]
    [SerializeField] private GameObject ShopPanel;
    [SerializeField] private GameObject AllCell;
    [SerializeField] private GameObject ResoursePanel;
    public bool CastleBuild;
    [Header("ErrorMessage")]
    [SerializeField] private GameObject ErrorResources;
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
    [Header("BuildPriceSaw")]
    public int GoldPriceSaw;
    public int WoodPriceSaw;
    public int StonePriceSaw;
    public Text GoldTextSaw;
    public Text WoodTextSaw;
    public Text StoneTextSaw;
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
        ErrorResources.SetActive(false);
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
        Build(Castle, GoldPriceCastle, WoodPriceCastle, StonePriceCastle);
        CastleBuild = true;
        Cancel();
    }

    public void BuildBarn()
    {
        Build(Barn, GoldPriceBarn, WoodPriceBarn, StonePriceBarn);
        Cancel();
    }

    public void BuildEnvil()
    {
        Build(Envil, GoldPriceEnvil, WoodPriceEnvil, StonePriceEnvil);
        Cancel();
    }

    public void BuildFarm()
    {
        Build(Farm, GoldPriceFarm, WoodPriceFarm, StonePriceFarm);
        Cancel();
    }

    public void BuildHouse()
    {
        Build(House, GoldPriceHouse, WoodPriceHouse, StonePriceHouse);
        Cancel();
    }

    public void BuildKitchen()
    {
        Build(Kitchen, GoldPriceKitchen, WoodPriceKitchen, StonePriceKitchen);
        Cancel(); 
    }

    public void BuildMine()
    {
        Build(Mine, GoldPriceMine, WoodPriceMine, StonePriceMine);
        Cancel();
    }

    public void BuildTent()
    {
        Build(Tent, GoldPriceTent, WoodPriceTent, StonePriceTent);
        Cancel();
    }

    public void BuildTower()
    {
        if (ResoursePanel.GetComponent<ResourceController>().Gold < 5000) //Особый план
        {
            ErrorResources.SetActive(true);
            return;
        }
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Tower);
                ResoursePanel.GetComponent<ResourceController>().Gold -= GoldPriceTower;
                ResoursePanel.GetComponent<ResourceController>().Wood -= WoodPriceTower;
                ResoursePanel.GetComponent<ResourceController>().Stone -= StonePriceTower;
                break;
            }
        }
        Cancel();
    }

    public void BuildSaw()
    {
        Build(Saw, GoldPriceSaw, WoodPriceSaw, StonePriceSaw);
        Cancel();
    }

    public void Build(GameObject Construction, int GoldPrice, int WoodPrice, int StonePrice)
    {
        if (ResoursePanel.GetComponent<ResourceController>().Gold < GoldPrice || ResoursePanel.GetComponent<ResourceController>().Wood < WoodPrice || ResoursePanel.GetComponent<ResourceController>().Stone < StonePrice)
        {
            ErrorResources.SetActive(true);
            return;
        }
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Construction);
                ResoursePanel.GetComponent<ResourceController>().Gold -= GoldPrice;
                ResoursePanel.GetComponent<ResourceController>().Wood -= WoodPrice;
                ResoursePanel.GetComponent<ResourceController>().Stone -= StonePrice;
                break;
            }
        }
    }
}

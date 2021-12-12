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
    public GameObject Flag;
    [Header("Other")]
    [SerializeField] private GameObject ShopPanel;
    [SerializeField] private GameObject AllCell;
    [SerializeField] private GameObject ResoursePanel;
    public bool CastleBuild;
    [Header("ErrorMessage")]
    [SerializeField] private GameObject ErrorResources;
    [SerializeField] private GameObject ErrorCastle;
    [SerializeField] private GameObject ErrorCastle2;
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
    [Header("BuildPriceFlag")]
    public int GoldPriceFlag;
    public int WoodPriceFlag;
    public int StonePriceFlag;
    public Text GoldTextFlag;
    public Text WoodTextFlag;
    public Text StoneTextFlag;

    void Start()
    {
        GetPrices();
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
            ErrorCastle.SetActive(true);
            return;
        }
        if (ResoursePanel.GetComponent<ResourceController>().Gold < GoldPriceCastle || ResoursePanel.GetComponent<ResourceController>().Wood < WoodPriceCastle || ResoursePanel.GetComponent<ResourceController>().Stone < StonePriceCastle)
        {
            ErrorResources.SetActive(true);
            return;
        }
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == false)
            {
                AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuild(Castle);
                ResoursePanel.GetComponent<ResourceController>().Gold -= GoldPriceCastle;
                ResoursePanel.GetComponent<ResourceController>().Wood -= WoodPriceCastle;
                ResoursePanel.GetComponent<ResourceController>().Stone -= StonePriceCastle;
                break;
            }
        }
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

    public void BuildFlag()
    {
        if (CastleBuild == false)
        {
            ErrorCastle2.SetActive(true);
            return;
        }

        if (ResoursePanel.GetComponent<ResourceController>().Gold < GoldPriceFlag || ResoursePanel.GetComponent<ResourceController>().Wood < WoodPriceFlag || ResoursePanel.GetComponent<ResourceController>().Stone < StonePriceFlag)
        {
            ErrorResources.SetActive(true);
            return;
        }
        for (int i = 0; i < AllCell.transform.childCount; i++)
        {
            if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().ActiveCell == true && AllCell.transform.GetChild(i).GetComponent<BuildManager>().Building == true)
            {

                if (AllCell.transform.GetChild(i).GetComponent<BuildManager>().Flag == false)
                {
                    AllCell.transform.GetChild(i).GetComponent<BuildManager>().SetBuildFlag(Flag);
                    ResoursePanel.GetComponent<ResourceController>().Gold -= GoldPriceFlag;
                    ResoursePanel.GetComponent<ResourceController>().Wood -= WoodPriceFlag;
                    ResoursePanel.GetComponent<ResourceController>().Stone -= StonePriceFlag;
                    AllCell.transform.GetChild(i).GetComponent<BuildManager>().Flag = true;
                    break;
                }
                
            }
        }
        Cancel();
    }
    public void Build(GameObject Construction, int GoldPrice, int WoodPrice, int StonePrice)
    {
        if (CastleBuild == false)
        {
            ErrorCastle2.SetActive(true);
            return;
        }
        
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

    private void GetPrices()
    {
        GoldTextCastle.text = GoldPriceCastle.ToString();
        WoodTextCastle.text = WoodPriceCastle.ToString();
        StoneTextCastle.text = StonePriceCastle.ToString();
        GoldTextTower.text = GoldPriceTower.ToString();
        WoodTextTower.text = WoodPriceTower.ToString();
        StoneTextTower.text = StonePriceTower.ToString();
        GoldTextFarm.text = GoldPriceFarm.ToString();
        WoodTextFarm.text = WoodPriceFarm.ToString();
        StoneTextFarm.text = StonePriceFarm.ToString();
        GoldTextMine.text = GoldPriceMine.ToString();
        WoodTextMine.text = WoodPriceMine.ToString();
        StoneTextMine.text = StonePriceMine.ToString();
        GoldTextHouse.text = GoldPriceHouse.ToString();
        WoodTextHouse.text = WoodPriceHouse.ToString();
        StoneTextHouse.text = StonePriceHouse.ToString();
        GoldTextTent.text = GoldPriceTent.ToString();
        WoodTextTent.text = WoodPriceTent.ToString();
        StoneTextTent.text = StonePriceTent.ToString();
        GoldTextBarn.text = GoldPriceBarn.ToString();
        WoodTextBarn.text = WoodPriceBarn.ToString();
        StoneTextBarn.text = StonePriceBarn.ToString();
        GoldTextSaw.text = GoldPriceSaw.ToString();
        WoodTextSaw.text = WoodPriceSaw.ToString();
        StoneTextSaw.text = StonePriceSaw.ToString();
        GoldTextEnvil.text = GoldPriceEnvil.ToString();
        WoodTextEnvil.text = WoodPriceEnvil.ToString();
        StoneTextEnvil.text = StonePriceEnvil.ToString();
        GoldTextKitchen.text = GoldPriceKitchen.ToString();
        WoodTextKitchen.text = WoodPriceKitchen.ToString();
        StoneTextKitchen.text = StonePriceKitchen.ToString();
        GoldTextFlag.text = GoldPriceFlag.ToString();
        WoodTextFlag.text = WoodPriceFlag.ToString();
        StoneTextFlag.text = StonePriceFlag.ToString(); 

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseScript : MonoBehaviour
{
    public int PersonInHouse;
    public int MaxPersonInHouse;
    public int PersonAdd;
    float PersonAddTime;
    public int Product;
    public int UseProduct;
    float UseProductTime;
    public int PersonDie;
    float PersonDieTime;
    public int Tax;
    public int TaxAdd;
    float TaxTime;

    GameObject Resources;
    void Start()
    {
        Resources = GameObject.FindGameObjectWithTag("ResourceController");
        Resources.GetComponent<ResourceController>().MaxResident += MaxPersonInHouse;
        Resources.GetComponent<ResourceController>().Building += 1;
    }

    
    void Update()
    {
        if (PersonInHouse < 0)
        {
            PersonInHouse = 0;
        }
        AddPerson();
        AddProduct();
        AddTax();
        PersonDied();
    }

    public void AddPerson()
    {
        PersonAddTime += 1 * Time.deltaTime;
        if (PersonAddTime >= PersonAdd)
        {
            if (Resources.GetComponent<ResourceController>().Resident < Resources.GetComponent<ResourceController>().MaxResident)
            {
                PersonInHouse += 1;
                Resources.GetComponent<ResourceController>().Resident += 1;
            }
            PersonAddTime = 0;
        }
    }

    public void AddProduct()
    {
        int AllProdust;
        UseProductTime += 1 * Time.deltaTime;
        if (UseProductTime >= UseProduct)
        {
            AllProdust = PersonInHouse * Product;
            if (AllProdust <= Resources.GetComponent<ResourceController>().Food)
            {
                Resources.GetComponent<ResourceController>().Food -= AllProdust;
            }
            else
            {
                while (AllProdust > Resources.GetComponent<ResourceController>().Food)
                {
                    PersonInHouse -= 1;
                    Resources.GetComponent<ResourceController>().Resident -= 1;
                    AllProdust -= 1;
                }
            }
            AllProdust = 0;
            UseProductTime = 0;
        }
    }

    public void AddTax()
    {
        int AllTax;
        TaxTime += 1 * Time.deltaTime;
        if (TaxTime >= TaxAdd)
        {
            AllTax = PersonInHouse * Tax;
            Resources.GetComponent<ResourceController>().Gold += AllTax;
            AllTax = 0;
        }
    }

    public void PersonDied()
    {
        PersonDieTime += 1 * Time.deltaTime;
        if (PersonDieTime >= PersonDie)
        {
            PersonInHouse -= 1;
            Resources.GetComponent<ResourceController>().Resident -= 1;
        }
    }
}

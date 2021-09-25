using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceController : MonoBehaviour
{
    public Text ResoursesText;
    [Header("Resourses")]
    public int Resident;
    public int MaxResident;
    public int Gold;
    public int Food;
    public int MaxFood;
    public int Wood;
    public int MaxWood;
    public int Stone;
    public int MaxStone;
    public int Building;
    [Header("ErrorMessage")]
    [SerializeField] private GameObject GoldMessage;
    [SerializeField] private GameObject StoneMessage;
    [SerializeField] private GameObject WoodMessage;


    void Update()
    {
        ResoursesText.text = "Жителей: " + Resident + "/" + MaxResident + "   Золото: " + Gold + "   Продуктов: " + Food + "/" + MaxFood +
            "\r\nДерево: " + Wood + "/" + MaxWood + "   Камней: " + Stone + "/" + MaxStone + "   Построений: " + Building;
        if (Food < 0)
        {
            Food = 0;
        }
        if (Resident < 0)
        {
            Resident = 0;
        }
        
        if (Gold < 2000)
        {
            GoldMessage.SetActive(true);
        }
        else
        {
            GoldMessage.SetActive(false);
        }

        if (Wood < 1000)
        {
            WoodMessage.SetActive(true);
        }
        else
        {
            WoodMessage.SetActive(false);
        }

        if (Stone < 1000)
        {
            StoneMessage.SetActive(true);
        }
        else
        {
            StoneMessage.SetActive(false);
        }
    }
}

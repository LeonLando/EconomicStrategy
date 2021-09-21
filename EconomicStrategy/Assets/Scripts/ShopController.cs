using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    [SerializeField] private GameObject ShopPanel;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void Cancel()
    {
        ShopPanel.SetActive(false);
    }
}

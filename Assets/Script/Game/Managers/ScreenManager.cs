using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour
{
    
    public GameObject shop;
    public GameObject main;
    public GameObject character;
    public GameObject idleshop;
    public GameObject prestige;
    public NumberOfUpgrades numberOfUpgrades;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleShop()
    {
        if(shop.active)
        {
            main.SetActive(true);
            shop.SetActive(false);
        }
        else
        {
            main.SetActive(false);
            shop.SetActive(true);

        }
    }

    public void ToggleChar()
    {
        if(character.active)
        {
            main.SetActive(true);
            character.SetActive(false);
        }
        else
        {
            main.SetActive(false);
            character.SetActive(true);

        }
    }

    public void ToggleIdleShop()
    {
        if(idleshop.active)
        {
            main.SetActive(true);
            idleshop.SetActive(false);
        }
        else
        {
            main.SetActive(false);
            idleshop.SetActive(true);

        }
    }

    public void TogglePrestige()
    {
        if(prestige.active)
        {
            main.SetActive(true);
            prestige.SetActive(false);
        }
        else
        {
            main.SetActive(false);
            prestige.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCurrentPrice : MonoBehaviour
{
    public ShowPrice showPrice;
    public int upgradeNumber;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.ShowCurrentUpgradePrice(this.upgradeNumber);
    }

    public void ShowCurrentUpgradePrice(int upgradeNumber)
    {
        gameObject.GetComponent<Text>().text = showPrice.nextprice[upgradeNumber - 1].ToString();
    }
}

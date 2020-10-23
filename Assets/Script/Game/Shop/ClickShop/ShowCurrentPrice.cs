using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCurrentPrice : MonoBehaviour
{
    public ShowPrice showPrice;
    public int upgradeNumber;

    private void Update()
    {
        this.ShowCurrentUpgradePrice(this.upgradeNumber);
    }

    public void ShowCurrentUpgradePrice(int upgradeNumber)
    {
        gameObject.GetComponent<Text>().text = showPrice.nextPrice[upgradeNumber - 1].ToString();
    }
}

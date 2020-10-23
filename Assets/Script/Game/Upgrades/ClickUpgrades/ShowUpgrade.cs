using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUpgrade : MonoBehaviour
{
    public NumberOfUpgrades numberOfUpgrades;
    public int upgradeNumber;
    
    private void Update()
    {
        this.ReturnUpgradeNumber();
    }

    public void ReturnUpgradeNumber()
    {
        gameObject.GetComponent<Text>().text = numberOfUpgrades.upgradesCount[upgradeNumber - 1].ToString();
    }
}

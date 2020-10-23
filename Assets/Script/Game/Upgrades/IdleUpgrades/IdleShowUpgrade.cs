using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleShowUpgrade : MonoBehaviour
{
    public IdleNumberOfUpgrades idleNumberOfUpgrades;
    public int idleUpgradeNumber;
    

    private void Update()
    {
        this.ReturnUpgradeNumber();
    }

    public void ReturnUpgradeNumber()
    {
        gameObject.GetComponent<Text>().text = idleNumberOfUpgrades.upgradesCount[idleUpgradeNumber - 1].ToString();
    }
}

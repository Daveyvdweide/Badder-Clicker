using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleShowNextMultiplier : MonoBehaviour
{
    public Text buttonText;
    public IdleNumberOfUpgrades idleNumberOfUpgrades;
    private float multiplier;
    private float upgradeCount;

    private void Update()
    {
        upgradeCount = idleNumberOfUpgrades.upgradesCount[0];
        this.multiplier = 0.2f + (upgradeCount * 0.01f);
        this.buttonText.GetComponent<Text>().text = "+ " + this.multiplier + " Candy per second";
    }
}

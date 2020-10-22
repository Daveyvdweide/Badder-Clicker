using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleShowNextMultiplier : MonoBehaviour
{
    public Text buttonText;
    public IdleNumberOfUpgrades idleNumberOfUpgrades;
    private float multiplier;
    private float upgradecount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        upgradecount = idleNumberOfUpgrades.upgradesCount[0];
        this.multiplier = 0.2f + (upgradecount * 0.01f);
        this.buttonText.GetComponent<Text>().text = "+ " + this.multiplier + " Candy per second";
    }
}

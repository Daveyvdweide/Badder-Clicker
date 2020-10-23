using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberOfUpgrades : MonoBehaviour
{
    public int[] upgradesCount;
    public Player player;
    
    private void Start()
    {
        Debug.Log("NumberOf" + 1);
    }

    public void ReturnUpgrade(int upgradeNumber)
    {
        GameObject.FindGameObjectWithTag("NumberOfUpgrades" + upgradeNumber.ToString()).GetComponent<Text>().text = this.upgradesCount[upgradeNumber - 1].ToString();
    }

    public void SetUpgrades(int upgradeNumber, int change)
    {
        this.upgradesCount[upgradeNumber - 1] = this.upgradesCount[upgradeNumber - 1] + change;
        player.upgradeCount[0] = this.upgradesCount[upgradeNumber - 1];
    }
}

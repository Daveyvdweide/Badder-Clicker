using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleShowPrice : MonoBehaviour
{
    public float[] startprice;
    public float[] idlenextprice;

    public IdleNumberOfUpgrades idleNumberOfUpgrades;
    void Start()
    {
        CalculatePrice();
    }

    // Update is called once per frame
    void Update()
    {
        CalculatePrice();
    }

    void CalculatePrice()
    {
        for (int i = 0; i < this.startprice.Length; i++)
        {
            if(this.idlenextprice[i] < 100)
            {
                this.idlenextprice[i] = this.startprice[i] + (this.startprice[i] / 10 + (idleNumberOfUpgrades.upgradesCount[i] * 1.30f * (i + 1)));
            }
            if(this.idlenextprice[i] < 300)
            {
                this.idlenextprice[i] = this.startprice[i] + (this.startprice[i] / 10 + (idleNumberOfUpgrades.upgradesCount[i] * 2.60f * (i + 1)));
            }
            if(this.idlenextprice[i] < 900)
            {
                this.idlenextprice[i] = this.startprice[i] + (this.startprice[i] / 10 + (idleNumberOfUpgrades.upgradesCount[i] * 3.90f * (i + 1)));
            }
            if(this.idlenextprice[i] < 2700)
            {
                this.idlenextprice[i] = this.startprice[i] + (this.startprice[i] / 10 + (idleNumberOfUpgrades.upgradesCount[i] * 4.30f * (i + 1)));
            }
            if(this.idlenextprice[i] < 7100)
            {
                this.idlenextprice[i] = this.startprice[i] + (this.startprice[i] / 10 + (idleNumberOfUpgrades.upgradesCount[i] * 6.60f * (i + 1)));
            }
            else
            {
                this.idlenextprice[i] = this.startprice[i] + (this.startprice[i] / 10 + (idleNumberOfUpgrades.upgradesCount[i] * 10f * (i + 1)));        
            }
        }
    }
}

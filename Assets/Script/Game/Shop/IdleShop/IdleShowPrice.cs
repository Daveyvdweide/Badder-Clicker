using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleShowPrice : MonoBehaviour
{
    public float[] startPrice;
    public float[] idlenextPrice;

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
        for (int i = 0; i < this.startPrice.Length; i++)
        {
            if(this.idlenextPrice[i] < 100)
            {
                this.idlenextPrice[i] = this.startPrice[i] + (this.startPrice[i] / 10 + (idleNumberOfUpgrades.upgradesCount[i] * 1.30f * (i + 1)));
            }
            if(this.idlenextPrice[i] < 300)
            {
                this.idlenextPrice[i] = this.startPrice[i] + (this.startPrice[i] / 10 + (idleNumberOfUpgrades.upgradesCount[i] * 2.60f * (i + 1)));
            }
            if(this.idlenextPrice[i] < 900)
            {
                this.idlenextPrice[i] = this.startPrice[i] + (this.startPrice[i] / 10 + (idleNumberOfUpgrades.upgradesCount[i] * 3.90f * (i + 1)));
            }
            if(this.idlenextPrice[i] < 2700)
            {
                this.idlenextPrice[i] = this.startPrice[i] + (this.startPrice[i] / 10 + (idleNumberOfUpgrades.upgradesCount[i] * 4.30f * (i + 1)));
            }
            if(this.idlenextPrice[i] < 7100)
            {
                this.idlenextPrice[i] = this.startPrice[i] + (this.startPrice[i] / 10 + (idleNumberOfUpgrades.upgradesCount[i] * 6.60f * (i + 1)));
            }
            else
            {
                this.idlenextPrice[i] = this.startPrice[i] + (this.startPrice[i] / 10 + (idleNumberOfUpgrades.upgradesCount[i] * 10f * (i + 1)));        
            }
        }
    }
}

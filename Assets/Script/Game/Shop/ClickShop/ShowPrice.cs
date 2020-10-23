using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPrice : MonoBehaviour
{
    public float[] startPrice;
    public float[] nextPrice;

    public NumberOfUpgrades numberOfUpgrades;

    private void Start()
    {
        CalculatePrice();
    }

    private void Update()
    {
        CalculatePrice();
    }

    public void CalculatePrice()
    {
        for (int i = 0; i < this.startPrice.Length; i++)
        {
            this.nextPrice[i] = this.startPrice[i] + (this.startPrice[i] / 10 + (numberOfUpgrades.upgradesCount[i] * 2 * (i + 1)));
        }
    }
}

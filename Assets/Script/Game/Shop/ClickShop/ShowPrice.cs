using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPrice : MonoBehaviour
{
    public float[] startprice;
    public float[] nextprice;

    public NumberOfUpgrades numberOfUpgrades;
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
            this.nextprice[i] = this.startprice[i] + (this.startprice[i] / 10 + (numberOfUpgrades.upgradesCount[i] * 2 * (i + 1)));
        }
    }
}

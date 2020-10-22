using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleShowCurrentPrice : MonoBehaviour
{
    public IdleShowPrice idleShowPrice;
    public int idleUpgradeNumber;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.ShowCurrentUpgradePrice(this.idleUpgradeNumber);
    }

    public void ShowCurrentUpgradePrice(int idleUpgradeNumber)
    {
        gameObject.GetComponent<Text>().text = idleShowPrice.idlenextprice[idleUpgradeNumber - 1].ToString();
    }
}

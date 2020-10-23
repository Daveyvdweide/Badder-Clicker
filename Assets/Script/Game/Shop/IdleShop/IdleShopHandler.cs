using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleShopHandler : MonoBehaviour
{
    public GameObject scoreManager;
    private float score;
    public GameObject idleshop;
    public GameObject warning;
    public bool isBought;
    public IdleNumberOfUpgrades idleNumberOfUpgrades;

    public IdleShowPrice idleShowPrice;

    public ClickingSoundHandler clickingSoundHandler;
    
    private void Start()
    {
        this.scoreManager = GameObject.FindGameObjectWithTag("ScoreManager");
    }

    private void Update()
    {
        if(this.idleshop.active)
        {
            this.score = this.scoreManager.GetComponent<ScoreHandler>().score;
        }       
    }

    public void BuyIdleUpgradeOne()
    {
        float price = idleShowPrice.idlenextPrice[0];
        float scorePerSecond = 0.2f + (idleNumberOfUpgrades.upgradesCount[0] * 0.01f);
        int id = 1;

        this.BuyIdleUpgrade(id, price, scorePerSecond);

        if(this.isBought == true)
        {
            this.idleNumberOfUpgrades.SetUpgrades(1, 1);
            clickingSoundHandler.PlayMeow();
        }
    }


    private void BuyIdleUpgrade(int id, float price, float scorePerSecond)
    {
        if(this.score > price)
        {
            this.scoreManager.GetComponent<ScoreHandler>().score = this.score - price;
            this.scoreManager.GetComponent<ScoreHandler>().scorePerSecond = this.scoreManager.GetComponent<ScoreHandler>().scorePerSecond + scorePerSecond;
            this.isBought = true;
        }
        else
        {
            StartCoroutine(NotEnoughPoints(2));
            this.isBought = false;
        }
    }

    private IEnumerator NotEnoughPoints(float seconds)
    {
        this.warning.SetActive(true);
        yield return new WaitForSeconds(seconds);
        this.warning.SetActive(false);
    }
}

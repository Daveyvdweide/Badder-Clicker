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
    // Start is called before the first frame update
    void Start()
    {
        this.scoreManager = GameObject.FindGameObjectWithTag("ScoreManager");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.idleshop.active)
        {
            this.score = this.scoreManager.GetComponent<ScoreHandler>().score;
        }       
    }

    public void BuyIdleUpgradeOne()
    {
        float price = idleShowPrice.idlenextprice[0];
        float scorepersecond = 0.2f + (idleNumberOfUpgrades.upgradesCount[0] * 0.01f);
        int id = 1;

        this.BuyIdleUpgrade(id, price, scorepersecond);

        if(this.isBought == true)
        {
            this.idleNumberOfUpgrades.SetUpgrades(1, 1);
            clickingSoundHandler.PlayMeow();
        }
    }


    private void BuyIdleUpgrade(int id, float price, float scorepersecond)
    {
        if(this.score > price)
        {
            this.scoreManager.GetComponent<ScoreHandler>().score = this.score - price;
            this.scoreManager.GetComponent<ScoreHandler>().scorepersecond = this.scoreManager.GetComponent<ScoreHandler>().scorepersecond + scorepersecond;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopHandler : MonoBehaviour
{
    public GameObject scoreManager;
    private float score;
    public GameObject shop;
    public GameObject warning;
    public bool isBought;
    public NumberOfUpgrades numberOfUpgrades;

    public ShowPrice showPrice;

    public ClickingSoundHandler clickingSoundHandler;

    void Start()
    {
        this.scoreManager = GameObject.FindGameObjectWithTag("ScoreManager");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.shop.active)
        {
            this.score = this.scoreManager.GetComponent<ScoreHandler>().score;
        }
    }

    public void BuyUpgradeOne()
    {
        float price = showPrice.nextprice[0];
        float multiplier = 0.2f;
        int id = 1;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(1, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeTwo()
    {
        float price = showPrice.nextprice[1];
        float multiplier = 0.4f;
        int id = 2;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(2, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeThree()
    {
        float price = showPrice.nextprice[2];
        float multiplier = 0.8f;
        int id = 3;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(3, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeFour()
    {
        float price = showPrice.nextprice[3];
        float multiplier = 2;
        int id = 4;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(4, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeFive()
    {
        float price = showPrice.nextprice[4];
        float multiplier = 4;
        int id = 5;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(5, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeSix()
    {
        float price = showPrice.nextprice[5];
        float multiplier = 6;
        int id = 6;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(6, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeSeven()
    {
        float price = showPrice.nextprice[6];
        float multiplier = 8;
        int id = 7;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(7, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeEight()
    {
        float price = showPrice.nextprice[7];
        float multiplier = 9;
        int id = 8;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(8, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeNine()
    {
        float price = showPrice.nextprice[8];
        float multiplier = 18;
        int id = 9;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(9, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeTen()
    {
        float price = showPrice.nextprice[9];
        float multiplier = 36;
        int id = 10;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(10, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeEleven()
    {
        float price = showPrice.nextprice[10];
        float multiplier = 72;
        int id = 11;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(11, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeTwelf()
    {
        float price = showPrice.nextprice[11];
        float multiplier = 144;
        int id = 12;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(12, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeThirteen()
    {
        float price = showPrice.nextprice[12];
        float multiplier = 288;
        int id = 13;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(13, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeFourteen()
    {
        float price = showPrice.nextprice[13];
        float multiplier = 576;
        int id = 14;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(14, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeFifteen()
    {
        float price = showPrice.nextprice[14];
        float multiplier = 1150;
        int id = 15;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(15, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeSixteen()
    {
        float price = showPrice.nextprice[15];
        float multiplier = 7500;
        int id = 16;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(16, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeSeventeen()
    {
        float price = showPrice.nextprice[16];
        float multiplier = 15000;
        int id = 17;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(17, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeEigthteen()
    {
        float price = showPrice.nextprice[17];
        float multiplier = 30000;
        int id = 18;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(18, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeNineteen()
    {
        float price = showPrice.nextprice[18];
        float multiplier = 60000;
        int id = 19;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(19, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    public void BuyUpgradeClick(float func_multiplier, int func_id)
    {
        float price = showPrice.nextprice[func_id - 1];
        float multiplier = func_multiplier;
        int id = func_id;

        this.BuyUpgrade(id, price, multiplier);

        if(this.isBought == true)
        {
            this.numberOfUpgrades.SetUpgrades(id, 1);
            clickingSoundHandler.PlayMeow();
        }
    }

    private void BuyUpgrade(int id, float price, float multiplier)
    {
        if(this.score > price)
        {
            this.scoreManager.GetComponent<ScoreHandler>().score = this.score - price;
            this.scoreManager.GetComponent<ScoreHandler>().scoremultiplier = this.scoreManager.GetComponent<ScoreHandler>().scoremultiplier + multiplier;
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

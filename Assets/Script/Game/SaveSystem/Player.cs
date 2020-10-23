using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Player : MonoBehaviour
{
    public float score;
    public float scoreMultiplier;
    public float scorePerSecond;

    public NumberOfUpgrades numberOfUpgrades;
    public IdleNumberOfUpgrades idleNumberOfUpgrades;
    public CharacterManager characterManager;

    public int[] upgradeCount = new int[18];
    public int idleupgradeCount;

    public int selectedCharacter;

    private void Start()
    {
        this.LoadPlayer();
        Debug.Log(this.upgradeCount.Length);
    }

    private void Update()
    {
        this.SavePlayer();
    }


    public void SavePlayer()
    {
        score = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreHandler>().score;
        scoreMultiplier = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreHandler>().scoreMultiplier;
        scorePerSecond = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreHandler>().scorePerSecond;

        for (int i = 0; i < upgradeCount.Length; i++)
        {
            upgradeCount[i] = numberOfUpgrades.upgradesCount[i];
        }

        idleupgradeCount = idleNumberOfUpgrades.upgradesCount[0];
        selectedCharacter = characterManager.characterIdOnScreen;
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreHandler>().score = data.score;
        GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreHandler>().scoreMultiplier = data.scoreMultiplier;
        GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreHandler>().scorePerSecond = data.scorePerSecond;

        for (int i = 0; i < upgradeCount.Length; i++)
        {
            numberOfUpgrades.upgradesCount[i] = data.upgradeCount[i];
        }

        idleNumberOfUpgrades.upgradesCount[0] = data.idleupgradeCount;

        characterManager.characterIdOnScreen = data.selectedCharacter;
    }
}

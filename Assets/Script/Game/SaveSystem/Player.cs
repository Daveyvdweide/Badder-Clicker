using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Player : MonoBehaviour
{
    public float score;
    public float scoremultiplier;
    public float scorepersecond;

    public NumberOfUpgrades numberOfUpgrades;
    public IdleNumberOfUpgrades idleNumberOfUpgrades;
    public CharacterManager characterManager;

    public int[] upgradeCount = new int[18];
    public int idleupgradecount;

    public int selectedcharacter;

    void Start()
    {
        this.LoadPlayer();
        Debug.Log(this.upgradeCount.Length);
    }

    void Update()
    {
        this.SavePlayer();
    }


    public void SavePlayer()
    {
        score = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreHandler>().score;
        scoremultiplier = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreHandler>().scoremultiplier;
        scorepersecond = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreHandler>().scorepersecond;

        for (int i = 0; i < upgradeCount.Length; i++)
        {
            upgradeCount[i] = numberOfUpgrades.upgradesCount[i];
        }

        idleupgradecount = idleNumberOfUpgrades.upgradesCount[0];
        selectedcharacter = characterManager.characterIdOnScreen;
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreHandler>().score = data.score;
        GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreHandler>().scoremultiplier = data.scoremultiplier;
        GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreHandler>().scorepersecond = data.scorepersecond;

        for (int i = 0; i < upgradeCount.Length; i++)
        {
            numberOfUpgrades.upgradesCount[i] = data.upgradeCount[i];
        }

        idleNumberOfUpgrades.upgradesCount[0] = data.idleupgradecount;

        characterManager.characterIdOnScreen = data.selectedcharacter;
    }
}

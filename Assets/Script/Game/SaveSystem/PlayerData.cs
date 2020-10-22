using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float score;
    public float scoremultiplier;
    public float scorepersecond;

    public int[] upgradeCount = new int[19];
    public int idleupgradecount;
    public int selectedcharacter;


    public PlayerData(Player player)
    {
        score = player.score;
        scoremultiplier = player.scoremultiplier;
        scorepersecond = player.scorepersecond;

        for (int i = 0; i < player.upgradeCount.Length; i++)
        {
            this.upgradeCount[i] = player.upgradeCount[i];
        }

        idleupgradecount = player.idleupgradecount;
        selectedcharacter = player.selectedcharacter;
    }
}

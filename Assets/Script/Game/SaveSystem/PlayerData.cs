using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float score;
    public float scoreMultiplier;
    public float scorePerSecond;

    public int[] upgradeCount = new int[19];
    public int idleupgradeCount;
    public int selectedCharacter;

    public PlayerData(Player player)
    {
        score = player.score;
        scoreMultiplier = player.scoreMultiplier;
        scorePerSecond = player.scorePerSecond;

        for (int i = 0; i < player.upgradeCount.Length; i++)
        {
            this.upgradeCount[i] = player.upgradeCount[i];
        }

        idleupgradeCount = player.idleupgradeCount;
        selectedCharacter = player.selectedCharacter;
    }
}

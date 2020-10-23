using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    private GameObject scoreManager;
    private float currentScore;
    private int showScore;
    private Text scoreText;

    private void Start()
    {
        this.scoreText = GetComponent<Text>();
        this.scoreManager = GameObject.FindGameObjectWithTag("ScoreManager");
    }

    private void Update()
    {
        this.GetScore();
    }

    public void GetScore()
    {
        this.currentScore = this.scoreManager.GetComponent<ScoreHandler>().score;
        this.showScore = Mathf.RoundToInt(this.currentScore);
        this.scoreText.text = showScore.ToString() + " candy!!";
    }
}

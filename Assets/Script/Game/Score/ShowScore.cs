using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    private GameObject ScoreManager;
    private float currentScore;
    private int showScore;
    private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GetComponent<Text>();
        this.ScoreManager = GameObject.FindGameObjectWithTag("ScoreManager");
    }

    // Update is called once per frame
    void Update()
    {
        this.GetScore();
    }

    void GetScore()
    {
        this.currentScore = this.ScoreManager.GetComponent<ScoreHandler>().score;
        this.showScore = Mathf.RoundToInt(this.currentScore);
        this.scoreText.text = showScore.ToString() + " candy!!";
    }
}

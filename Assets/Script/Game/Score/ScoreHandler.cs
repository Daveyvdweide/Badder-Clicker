using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    public float score = 0;
    public float scoreMultiplier = 1;
    public float scorePerSecond = 1;
    private float timeElapsed = 0f;

    public void Update()
    {
        Debug.Log(scorePerSecond);
        if(this.timeElapsed > 1f)
        {
            Debug.Log(this.score);
            this.score = this.score + this.scorePerSecond;
            Debug.Log(this.score);
            this.timeElapsed = 0f;
        } 
        else 
        {
            this.timeElapsed = this.timeElapsed += Time.deltaTime;
        }
    }

    public void AddScore(string test)
    {
        this.score = this.score + (1 * this.scoreMultiplier); 
    }
}

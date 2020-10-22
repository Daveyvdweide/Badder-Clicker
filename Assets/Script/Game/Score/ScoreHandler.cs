using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    public float score = 0;
    public float scoremultiplier = 1;
    public float scorepersecond = 1;
    private float timeelapsed = 0f;

    public void Start()
    {
   
    }

    public void Update()
    {
        Debug.Log(scorepersecond);
        if(this.timeelapsed > 1f)
        {
            Debug.Log(this.score);
            this.score = this.score + this.scorepersecond;
            Debug.Log(this.score);
            this.timeelapsed = 0f;
        } 
        else 
        {
            this.timeelapsed = this.timeelapsed += Time.deltaTime;
        }
    }

    public void ReturnScore()
    {

    }

    public void AddScore(string test)
    {
        this.score = this.score + (1 * this.scoremultiplier); 
    }
}

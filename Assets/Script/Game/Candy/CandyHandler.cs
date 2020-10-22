using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyHandler : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject[] candy;
    public ScoreHandler scoreHandler;
    private float timeelapsed;
    private float numberofcandies;
    void Start()
    {
        StartCoroutine(PassiveCandySpawner(1));
    }

    void Update()
    {
        // if(this.timeelapsed > 1f)
        // {
        //     this.numberofcandies = scoreHandler.scorepersecond / (this.scoreHandler.scoremultiplier / 1f);
        //     for (int i = 0; i < numberofcandies; i++)
        //     {
        //         this.RandomCandy();
        //     }
        // } 
        // else 
        // {
        //     this.timeelapsed = this.timeelapsed += Time.deltaTime;
        // }
    }

    public void RandomCandy()
    {
        Instantiate(this.candy[Random.Range(0, 19)], this.spawnPoints[Random.Range(0, 25)].transform.position, Quaternion.identity);
    }

    private IEnumerator PassiveCandySpawner(float seconds)
    {
        this.RandomCandy();
        yield return new WaitForSeconds(seconds);
        StartCoroutine(PassiveCandySpawner(1));
    }
}

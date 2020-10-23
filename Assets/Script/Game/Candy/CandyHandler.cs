using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyHandler : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject[] candy;
    public ScoreHandler scoreHandler;
    
    private void Start()
    {
        StartCoroutine(PassiveCandySpawner(1));
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

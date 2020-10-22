using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    public GameObject candy;
    void Start()
    {
        StartCoroutine(DespawnCandy(5f));   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator DespawnCandy(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(candy);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    public GameObject candy;

    private void Start()
    {
        StartCoroutine(DespawnCandy(5f));   
    }

    private IEnumerator DespawnCandy(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(candy);
    }
}

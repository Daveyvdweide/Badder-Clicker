using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickingSoundHandler : MonoBehaviour
{
     public AudioClip[] audioClips;
     public AudioClip[] badderClips;
     public AudioSource audioSource;
     public AudioListener audioListener;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayRandom()
    {
         audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
         audioSource.Play();
    }

    public void PlayMeow()
    {
        audioSource.clip = badderClips[Random.Range(0, badderClips.Length)];
        audioSource.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicLoader : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip[] musicCollection;
    [SerializeField] private AudioClip[] radioIntros;

    //there is a fixed set of intros and songs for the radio
    //the songs are random songs from different genre to give the feeling like you're listening to the radio like we do in the real world
    //the script first starts a with a radio intro
    //after a intro a random song will be selected and played
    //when a song ends, a new starts.

    private void Start()
    {
        audioSource.clip = radioIntros[Random.Range(0, radioIntros.Length)];
        audioSource.Play();
    }

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = musicCollection[Random.Range(0, musicCollection.Length)];
            audioSource.Play();
        }
    }
}
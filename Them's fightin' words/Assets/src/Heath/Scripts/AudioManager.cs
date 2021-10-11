using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager
{

    AudioSource audioSource;

    public void play(AudioClip audio)
    {
        audioSource.PlayOneShot(audio);
    }

    public void loop(AudioClip audio, bool condition)
    {
        while(condition)
        {
            audioSource.PlayOneShot(audio);
        }

    }
}

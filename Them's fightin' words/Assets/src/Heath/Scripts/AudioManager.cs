using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AudioManager
{
    static GameObject audio = new GameObject();
    static AudioSource audioSource = audio.AddComponent<AudioSource>();

    public static void Play(AudioClip audioclip)
    {
        audioSource.PlayOneShot(audioclip);
    }

    public static void Loop(AudioClip audioclip)
    {
        audioSource.clip = audioclip;
        audioSource.loop = true;
        audioSource.Play();
    }
}

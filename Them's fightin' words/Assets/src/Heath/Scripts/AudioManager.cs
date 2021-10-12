﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AudioManager
{
    public static void Play(AudioClip audioclip)
    {
        GameObject audio = new GameObject();
        AudioSource audioSource = audio.AddComponent<AudioSource>();
        audioSource.PlayOneShot(audioclip);
    }

    public static void Loop(AudioClip audioclip)
    {
        GameObject audio = new GameObject();
        AudioSource audioSource = audio.AddComponent<AudioSource>();
        audioSource.clip = audioclip;
        audioSource.loop = true;
        audioSource.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //public AudioSource menuMusic;
    //public AudioSource worldMusic;
    //public AudioSource fightMusic;
    public AudioSource source;
    public AudioClip jump;
    public AudioClip pickup;

    //play button sound
    public void playJump()
    {
        source.clip = jump;
        source.Play();
    }


    //play pickup sound
   /* public void playPickup()
    {
        pickup.Play();
    }*/

}

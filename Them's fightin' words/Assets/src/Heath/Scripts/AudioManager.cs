using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //public AudioSource menuMusic;
    //public AudioSource worldMusic;
    //public AudioSource fightMusic;

    public AudioSource jump;
    public AudioSource pickup;

    //play button sound
    public void playJump()
    {
        jump.Play();
    }


    //play pickup sound
   /* public void playPickup()
    {
        pickup.Play();
    }*/

}

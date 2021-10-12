using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLibrary : MonoBehaviour
{
    private static AudioLibrary libraryObject = null;
    private static readonly object instanceLock = new object();
    public static AudioLibrary Library
    {
        get{
            lock (instanceLock)
            {
                if (libraryObject == null)
                {
                    libraryObject = Instantiate(Resources.Load<AudioLibrary>("AudioLibrary"));
                }
                return libraryObject;
            }
        }
    }
     

    //Music Library
    public AudioClip Menu1;
    public AudioClip Menu2;
    public AudioClip Fight1;
    public AudioClip Fight2;
    public AudioClip World1;
    public AudioClip World2;
    public AudioClip World3;
    public AudioClip World4;
    public AudioClip World5;

    //Sound Library
    public AudioClip Move;
    public AudioClip Jump;
    public AudioClip Pickup;
    public AudioClip Select;
    public AudioClip Die;

}

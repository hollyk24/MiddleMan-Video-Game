/*
 * Filename: AudioLibrary.cs
 * Developer: Heath Thompson
 * Purpose: This file stores the audio files used by the Audio Manager in Them's Fightin' Words
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioLibrary : MonoBehaviour
{
    private static AudioLibrary m_libraryObject;
    private static readonly object m_instanceLock = new object();

/*
 * A class to store the audio files used by Them's Fightin' Words.
 *
 */
    public static AudioLibrary Library
    {
        get{
            lock (m_instanceLock)
            {
                if (m_libraryObject == null)
                {
                    m_libraryObject = Instantiate(Resources.Load<AudioLibrary>("AudioLibrary"));
                }
                return m_libraryObject;
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



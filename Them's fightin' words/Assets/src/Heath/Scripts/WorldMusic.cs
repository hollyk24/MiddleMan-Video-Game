/*
 * Filename: WorldMusic.cs
 * Developer: Heath Thompson
 * Purpose: This file stores the audio files used by the Audio Manager in Them's Fightin' Words
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * An empty class to demonstrate comments.
 *
 * Member variables:
 * m_isClass -- Boolean to demonstrate a member variable comment.
 */
public class WorldMusic : MonoBehaviour
{

/*
 * An empty class to demonstrate comments.
 *
 * Member variables:
 * m_isClass -- Boolean to demonstrate a member variable comment.
 */
    private void Awake()
    {
        AudioManager.Loop(AudioLibrary.Library.World1);
    }
}



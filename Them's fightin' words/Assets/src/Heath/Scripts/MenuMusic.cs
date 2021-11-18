/*
 * Filename: MenuMusic.cs
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
public class MenuMusic : MonoBehaviour
{

    private void Awake()
    {
        AudioManager.Loop(AudioLibrary.Library.Menu1);
    }
}



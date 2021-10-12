using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMusic : MonoBehaviour
{
    private void Awake()
    {
        AudioManager.Loop(AudioLibrary.Library.World1);
    }
}

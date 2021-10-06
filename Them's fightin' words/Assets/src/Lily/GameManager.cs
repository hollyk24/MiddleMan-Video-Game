using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This stores references to all singleton classes in order to make them easier to accsess
 * Reduce the amount of finds
 * 
 */
public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public static Controls controls;
    public static FileManager fm;

    private void Awake() {
        if (gm != null) gm = this;
        else Destroy(this);

        controls = new Controls();
        fm = FindObjectOfType<FileManager>();
    }
}

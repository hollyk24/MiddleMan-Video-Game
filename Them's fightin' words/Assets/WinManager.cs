// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// public class WinManager : MonoBehaviour
// {
//     [SerializeField] public GameObject gameWonUI;
//     [SerializeField] public WinTracker WT;
//     public void Start()
//     {
//         WT = gameObject.FindGameObjectWithTag("GameWonUI");;
//         if (WT.checkWins())
//         {
//             Time.timeScale = 0;
//             gameWonUI.SetActive(true);
//         }

//     }
// }
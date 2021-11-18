using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    [SerializeField] Slider Slider;
    //public static float Vol = 1;
    public void SetVolume()
    {
        //Vol = Slider.value;
        GameObject[] Audio = GameObject.FindGameObjectsWithTag("Pool Object");
        for( int i = 0; i < Audio.Length; i++)
        {
            Audio[i].GetComponent<AudioSource>().volume = Slider.value;
        }
    }
}

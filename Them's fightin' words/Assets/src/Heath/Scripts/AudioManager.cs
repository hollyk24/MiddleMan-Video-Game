/*
 * Filename: AudioManager.cs
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
public class AudioManager : MonoBehaviour
{
    //string scene = SceneManagement.GetActiveScene()
    // if scene is this, play this music

    private static AudioManager m_Manager;
    private static readonly object m_InstanceLock = new object();
    private static ObjectPool Pool = new ObjectPool();

   public static AudioManager Manager
    {
        get
        {
            lock (m_InstanceLock)
            {
                if (m_Manager == null)
                {
                    GameObject AudioObject = new GameObject();
                    m_Manager = AudioObject.AddComponent<AudioManager>();
                }
                return m_Manager;
            }
        }
    }

    private void Awake()
    {
        if(m_Manager == null)
        {
            m_Manager = this;
        }
        else if(m_Manager != null && m_Manager != this)
        {
            Debug.Log("here");
            Destroy(gameObject);
        }
    }


    public static void Play(AudioClip audioclip)
    {
        GameObject audio = new GameObject();
        AudioSource Source = audio.AddComponent<AudioSource>();
        Source.clip = audioclip;
        Source.Play();
        Destroy(audio, Source.clip.length);

        /*GameObject audio = Pool.GetObject();
        AudioSource Source = audio.GetComponent<AudioSource>();
        //Source.volume = Volume.Vol;
        Source.clip = audioclip;
        Source.PlayOneShot(Source.clip);
        Pool.RecycleObject(audio);*/
    }

    public static void Loop(AudioClip audioclip)
    {
        GameObject audio = new GameObject();
        AudioSource Source = audio.AddComponent<AudioSource>();
        Source.clip = audioclip;
        Source.loop = true;
        Source.Play();

        /*GameObject audio = Pool.GetObject();
        Debug.Log("check");
        AudioSource Source = audio.GetComponent<AudioSource>();
        Debug.Log("check1");
        //Source.volume = Volume.Vol;
        Source.clip = audioclip;
        Source.loop = true;
        Source.Play();*/
    }

    public static void Pause(GameObject Obj)
    {
        Obj.GetComponent<AudioSource>().Pause();
    }

    public static void UnPause(GameObject Obj)
    {
        Obj.GetComponent<AudioSource>().UnPause();
    }

    public static void Mute(GameObject Obj)
    {
        Obj.GetComponent<AudioSource>().mute = true;
    }

    public static void UnMute(GameObject Obj)
    {
        Obj.GetComponent<AudioSource>().mute = false;
    }

}



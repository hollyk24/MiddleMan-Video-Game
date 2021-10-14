using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;


namespace Tests
{
    public class HeathTests
    {
        
        // A Test behaves as an ordinary method
        [UnityTest]
        public IEnumerator WorldMusicCheck()
        {
            SceneManager.LoadScene("lilyTestScene");
            yield return new WaitForSeconds(2f);
            //This code below gets the audio currently playing in the scene
            AudioSource actual = GameObject.Find("MusicObject").GetComponent<AudioSource>();
            Assert.AreEqual(AudioLibrary.Library.World1, actual.clip);
        }

        // A Test behaves as an ordinary method
        [UnityTest]
        public IEnumerator MenuMusicCheck()
        {
            SceneManager.LoadScene("MainMenu");
            yield return new WaitForSeconds(2f);
            //This code below gets the audio currently playing in the scene
            AudioSource actual = GameObject.Find("MusicObject").GetComponent<AudioSource>();
            Assert.AreEqual(AudioLibrary.Library.Menu1, actual.clip);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator MusicLoopStress()
        {
            yield return new WaitForSeconds(1f);
            GameObject actual = GameObject.Find("MusicObject");     //find AudioObject

            int i = 0;
            while (i <= 50)
            {
                AudioManager.Loop(AudioLibrary.Library.World1);
                yield return new WaitForSeconds(0.1f);
                Debug.Log("Number of Audio Objects: " + i);
                i++;
            }

        }
    }
}

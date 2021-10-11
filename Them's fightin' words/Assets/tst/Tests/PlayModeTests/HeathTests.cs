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

        [SetUp]
        public void loadScene()
        {
            SceneManager.LoadScene("lilyTestScene");
        }
        // A Test behaves as an ordinary method
        [Test]
        public void AudioListenerActive()
        {
            // Use the Assert class to test conditions
            //assert there is an audiolistener in the scene
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator HeathTestsWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}

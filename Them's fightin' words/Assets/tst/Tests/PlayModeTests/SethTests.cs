using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests
{
    public class SethTests
    {
        [SetUp]
        public void loadScene(){
            SceneManager.LoadScene("lilyTestScene");
        }
        // A Test behaves as an ordinary method
        // [Test]
        // public void SethTestsSimplePasses()
        // {
            // Use the Assert class to test conditions
        // }
        
        [UnityTest]
        public IEnumerator PlayerLocationTest(){
            SceneManager.LoadScene("lilyTestScene");
            yield return new WaitForSeconds(2);
            GameObject player = GameObject.Find("PLAYER");
            
            // GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.GetComponent<playerMovement>().autoMoveLoop();
            // player.speedMultiplier = 10;
            yield return new WaitForSeconds(5);
            player.GetComponent<playerMovement>().autoMoveLoop();
            yield return new WaitForSeconds(1);
            Vector3 pos = player.transform.position;
            Assert.IsTrue(Mathf.Approximately(pos.x - Mathf.Round(pos.x), 0), pos.x.ToString()); // Check that location is a whole number.
            Assert.IsTrue(Mathf.Approximately(pos.y - Mathf.Round(pos.y), 0), pos.y.ToString());
            yield return null;
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator SethTestsWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}

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
        public void loadScene()
        {
            SceneManager.LoadScene("lilyTestScene");
        }
        // A Test behaves as an ordinary method
        // [Test]
        // public void SethTestsSimplePasses()
        // {
        // Use the Assert class to test conditions
        // }

        [UnityTest]
        public IEnumerator PlayerLocationTest()
        {
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
            Assert.IsTrue(Mathf.Approximately(pos.x - Mathf.Round(pos.x), 0.5f), pos.x.ToString()); // Check that location is a whole number.
            Assert.IsTrue(Mathf.Approximately(pos.y - Mathf.Round(pos.y), 0), pos.y.ToString());
            yield return null;
        }

        [UnityTest]
        public IEnumerator PlayerDiagonalTest()
        {
            SceneManager.LoadScene("lilyTestScene");
            yield return new WaitForSeconds(2);
            GameObject player = GameObject.Find("PLAYER");
            Rigidbody2D rb;
            bool movedDiagonally = false;
            // player.speedMultiplier = 10;
            player.GetComponent<playerMovement>().autoMoveLoop();
            // yield return new WaitForSeconds(5);
            float startTime = Time.time;
            Vector2 movementError = new Vector2(0,0);

            // Unsure if this loop is correct
            while(Time.time < startTime + 5){
                rb = player.GetComponent<Rigidbody2D>();
                if (rb.velocity.x * rb.velocity.y != 0)
                {
                    // If the product of the velocities is ever not equal to 0, the player moved diagonally.
                    movementError = new Vector2(rb.velocity.x, rb.velocity.y);
                    movedDiagonally = true;
                }
                yield return new WaitForSeconds(0.01f);
            }
            player.GetComponent<playerMovement>().autoMoveLoop();
            yield return new WaitForSeconds(1);
            Assert.IsFalse(movedDiagonally, movementError.ToString());
            yield return null;
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.

        [UnityTest]
        public IEnumerator PlayerCountStressTest()
        {
            SceneManager.LoadScene("lilyTestScene");
            yield return new WaitForSeconds(2);
            GameObject player = GameObject.Find("PLAYER");
            player.GetComponent<playerMovement>().autoMoveLoop();
            int playerCount = 1;
            float approxFPS;
            while(true){
                playerCount++;
                player.GetComponent<playerMovement>().cloneThisObject();
                yield return new WaitForSeconds(0.2f);
                approxFPS = 1/Time.deltaTime;
                Assert.IsTrue(approxFPS > 30, playerCount.ToString());
            }
            // yield return new WaitForSeconds(5);
        }
    }
}

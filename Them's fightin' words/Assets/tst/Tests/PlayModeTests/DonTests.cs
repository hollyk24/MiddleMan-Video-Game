using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class DonTests
    {

        [UnityTest]
        public IEnumerator PlayerCollisionTest()
        {
            // Load the scene
            SceneManager.LoadScene("CollisionTestScene");
            //Wait for scene to load
            yield return new WaitForSeconds(2);
            //Find player object
            GameObject player = GameObject.Find("PLAYER");
            //Get player location
            Vector3 pos = player.transform.position;
            //Loop
            for(float i = 0; i < 1000; i++)
            {
                //Increase movement speed and move player randomly
                player.GetComponent<playerMovement>().autoMoveSetSpeed(i * i);
                yield return new WaitForSeconds(0.000000001f);
                //Check if player is in bounds
                Assert.IsTrue(pos.x < 4);
                Assert.IsTrue(pos.x > -4);
                Assert.IsTrue(pos.y < 2.5);
                Assert.IsTrue(pos.y > -2.5);
            }
            yield return new WaitForSeconds(2);
            Assert.IsTrue(true);
        }
        [UnityTest]
        public IEnumerator WalkTileCountStressTest()
        {
            // Load the scene
            SceneManager.LoadScene("CollisionTestScene");
            // Wait for scene to load
            yield return new WaitForSeconds(2);
            // Find Walkable Path object
            GameObject tile = GameObject.Find("Walkable_Path");
            int tileCount = 40; // We start with 40 tiles
            float approxFPS; // To keep track of FPS (approximately)
            do
            {
                tile.GetComponent<WalkableTile>().cloneThisObject(); // Clone tile object
                tileCount++; // Increase count
                approxFPS = 1 / Time.deltaTime; // Get approximate FPS
                yield return new WaitForSeconds(0.000005f); // Wait so we don't crash the PC
            } while (approxFPS > 30); // Loop until FPS is less than 30

            // Log the number of tiles it took to lower the FPS below 30
            tile.GetComponent<WalkableTile>().debugOut(tileCount.ToString());
            yield return null;
        }
    }
}

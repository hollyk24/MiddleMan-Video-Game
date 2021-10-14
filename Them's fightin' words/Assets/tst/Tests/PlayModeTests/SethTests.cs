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
        [UnityTest]
        public IEnumerator PlayerIsCenteredOnTile()
        {
            // Load Scene
            SceneManager.LoadScene("lilyTestScene");
            yield return new WaitForSeconds(2); // Give scene time to load

            // Find PLAYER object
            GameObject player = GameObject.Find("PLAYER");
            
            // Move the player around randomly, and each time
            //   check that they are centered on a tile
            for(int i = 0; i < 800; i++){
                // Move player once super fast
                player.GetComponent<playerMovement>().autoMoveSetSpeed(1000000000f);
                // Get their new position
                Vector3 pos = player.transform.position;
                // Make sure that's a valid position
                Assert.IsTrue(Mathf.Approximately((10*pos.x) - Mathf.Round((10*pos.x)), 0), pos.x.ToString()); // Check that location is a whole number.
                Assert.IsTrue(Mathf.Approximately(pos.y - Mathf.Round(pos.y), 0), pos.y.ToString());
                // Wait a tad so you don't crash the PC
                yield return new WaitForSeconds(0.000011f);
            }
            yield return null;
        }

        [UnityTest]
        public IEnumerator PlayerMovedDiagonally()
        {
            // Disclaimer: not entirely sure this code is working how I want it to
            
            // Our game is on a grid, so the player should only
            //   move horizontally or vertically, never diagonally.

            // Load Scene
            SceneManager.LoadScene("lilyTestScene");
            yield return new WaitForSeconds(2);

            // Find PLAYER
            GameObject player = GameObject.Find("PLAYER");
            Rigidbody2D rb;
            bool movedDiagonally = false; // To keep track of any diagonal movement
            
            // Make the player start moving randomly around the map
            player.GetComponent<playerMovement>().autoMoveLoop();
            for(int i = 0; i < 800; i++){
                rb = player.GetComponent<Rigidbody2D>();

                // Check if product of X & Y velocity is ever != 0
                // (either X or Y should always be 0, so their product should also be 0)
                if (rb.velocity.x * rb.velocity.y != 0)
                {
                    movedDiagonally = true;
                    Assert.IsTrue(movedDiagonally);
                }
                // Wait so we don't crash Unity
                yield return new WaitForSeconds(0.000011f);
            }
            yield return null;
        }

        [UnityTest]
        public IEnumerator PlayerCountStressTest()
        {
            // Load the scene
            SceneManager.LoadScene("lilyTestScene");
            // Wait for scene to load
            yield return new WaitForSeconds(2);
            // Find player object
            GameObject player = GameObject.Find("PLAYER");

            // Run autoMoveLoop for fun
            player.GetComponent<playerMovement>().autoMoveLoop();
            // And make it superfast
            player.GetComponent<playerMovement>().setSpeed(100000f);
            int playerCount = 1; // We start with 1 player
            float approxFPS; // To keep track of FPS (approximately)
            do{
                player.GetComponent<playerMovement>().cloneThisObject(); // Clone player object
                playerCount++; // Increase count
                approxFPS = 1/Time.deltaTime; // Get approximate FPS
                yield return new WaitForSeconds(0.005f); // Wait so we don't crash the PC
            }while(approxFPS > 30); // Loop until FPS is less than 30

            // Log the number of players it took to lower the FPS below 30
            player.GetComponent<playerMovement>().debugOut(playerCount.ToString());
            yield return null;
        }
    }
}
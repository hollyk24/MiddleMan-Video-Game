using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayModeTests
    {
        public GameObject NPC;

        //[SetUp]
        public void loadScene()
        {
            SceneManager.LoadScene("heathstresstest");
        }
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator ExampleTest()
        {
            SceneManager.LoadScene("heathstresstest");

            yield return new WaitForSeconds(1);

            GameObject NPC = GameObject.FindGameObjectWithTag("NPC");
            GameObject Player = GameObject.FindGameObjectWithTag("Player");
            var NPCPosition = NPC.transform;
            //Vector3 NPCStart = new Vector3(5.6f, -2.3f, 0);
            //var PlayerPosition = Player.transform;
            for (int i = 0; i < 10; i++)
            {
                yield return new WaitForSeconds(1);
                Object.Instantiate(NPC);
                Debug.Log("spawn");
            }
            //Assert.Less
        }
        
    }
}

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
        [SetUp]
        public void loadScene()
        {
            SceneManager.LoadScene("tileTesting");
        }
        // A Test behaves as an ordinary method
        [Test]

        public void CheckWalkPaths()
        {
            // Use the Assert class to test conditions
            //Vector3 NPCLoc = GameObject.Find("NPC MATH").GetComponent<Transform>().position;
            //Vector3 ColLoc = new Vector3(NPCLoc.x, NPCLoc.y - 0.5, NPCLoc.z);
            //Walkmap.GetCellCenterWorld(Walkmap.WorldToCell())
            //GameObject actual = GameObject.Find("Walkable_Path_1");
            //Assert.IsInstanceOf(WalkableTile, actual);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        //[UnityTest]
        //public IEnumerator NewTestScriptWithEnumeratorPasses()
        //{
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
        //    yield return null;
        //}
    }
}

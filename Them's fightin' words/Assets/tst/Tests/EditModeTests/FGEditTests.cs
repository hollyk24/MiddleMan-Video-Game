using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor;

namespace Tests
{
    public class FGEditTests
    {
        public GameObject TestBox;

        // A Test behaves as an ordinary method
        [Test]
        public void FGTestHealthValues()
        {
            TestBox = new GameObject();
            ObjectFactory.AddComponent<Character>(TestBox);
            Character TestChar = TestBox.GetComponent<Character>();
            Assert.AreEqual(50, TestChar.health, "Health: 50 = " + TestChar.health);
            Object.DestroyImmediate(TestBox);
        }

        [Test]
        public void FGTestMovementValues()
        {
            TestBox = new GameObject();
            Character TestChar = ObjectFactory.AddComponent<Character>(TestBox);
            Vector3 storage = new Vector3(TestChar.transform.position.x, TestChar.transform.position.y, TestChar.transform.position.z);
            TestChar.Move(1);
            Assert.AreEqual(new Vector3(storage.x+TestChar.speed*0.01f, storage.y, storage.z), TestChar.transform.position, "Moved Forward Failure: + " + 5*0.01f);
            TestChar.Move(-1);
            TestChar.Move(-1);
            Assert.AreEqual(new Vector3(storage.x-0.05f, storage.y, storage.z), TestChar.transform.position, "Moved Backward Failure: 0.05f");
            Object.DestroyImmediate(TestBox);
        }

        [Test]
        public void FGStressTestPlayerCount()
        {
            int k = 2;
            while (k<100) {
                GameObject[] StressBoxes = new GameObject[k];
                Character[] StressChars = new Character[k];
                for(int i = 0; i < k; i++) {
                    StressBoxes[i] = new GameObject();
                    StressChars[i] = ObjectFactory.AddComponent<Character>(StressBoxes[i]);
                    Vector3 storage = new Vector3(StressChars[i].transform.position.x, StressChars[i].transform.position.y, StressChars[i].transform.position.z);
                    StressChars[i].Move(1);
                    Assert.AreEqual(new Vector3(storage.x+StressChars[i].speed*0.01f, storage.y, storage.z), StressChars[i].transform.position, k + "# runs: Mass Move Forward" + i + ": " + 5*0.01f);
                    //Assert.IsTrue((Time.frameCount / Time.time)>45, "FrameRate dipped at " + k + "players."); Stick this in update() for a play test
                }
                
                for(int i = 0; i < k; i++) {
                    Object.DestroyImmediate(StressBoxes[i]);
                }
                k++;
            }
        }

    }

}

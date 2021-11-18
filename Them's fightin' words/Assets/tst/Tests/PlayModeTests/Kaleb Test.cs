using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using NUnit.Framework;

namespace Tests
{
    public class KalebTest
    {
        public void loadTScene() {
            SceneManager.LoadScene("FGTestScene");
        }

        [UnityTest]
        /*Tests the number of simultaneous enemies that can exist under the current system*/
        public IEnumerator NPCStressTest() {
            loadTScene();
            yield return new WaitForSeconds(1);

            var NPC = GameObject.FindGameObjectWithTag("NPC");
            int count = 0;
            while((int)(1f / Time.unscaledDeltaTime) > 30) {
                GameObject.Instantiate(NPC);
                count++;
                yield return null;
            }
            Debug.Log("NPCs spawned by stress test: " + count);
            LogAssert.Expect(LogType.Log, "NPCs spawned by stress test: " + count);
            Assert.IsTrue(true);
            yield return null;
        }
    }
}

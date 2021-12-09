using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using NUnit.Framework;
using UnityEditor;
using FightCharacter;

namespace Tests
{
    public class KalebTest
    {
        private GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/src/Kaleb/TestNPC.prefab");

        public void loadTScene() {
            SceneManager.LoadScene("FGTestScene");
        }

        [UnityTest]
        public IEnumerator AttackTest() {
            loadTScene();
            GameObject player = GameObject.Find("Player");
            Debug.Log(player);
            GameObject NPC = GameObject.Find("NPC");
            Debug.Log(NPC);
            yield return new WaitForSeconds(1);
            Player Tester = player.GetComponent<Player>();
            NPC PunchingBag = NPC.GetComponent<NPC>();
            Tester.Attack(Tester.Attack1);
            yield return new WaitForSeconds(1);
            Assert.IsTrue(PunchingBag.health == 100 - Tester.Attack1.damage);
            yield return null;
        }

        [UnityTest]
        public IEnumerator TimerTest() {
            loadTScene();
            GameObject manager = GameObject.Find("FGManager");
            yield return null;
        }

        [UnityTest]
        /*Tests the number of simultaneous enemies that can exist under the current system*/
        public IEnumerator NPCStressTest() {
            loadTScene();
            List<GameObject> TestNPCs = new List<GameObject>(); 
            yield return new WaitForSeconds(1);
            int count = 0;

            while((int)(1.0f / Time.unscaledDeltaTime) > 30) {
                //Debug.Log("Loop "+count);
                GameObject newNPC = GameObject.Instantiate(prefab);
                TestNPCs.Add(newNPC);
                Debug.Log("NPC Created: "+ count);
                Debug.Log("NPC x, y" + newNPC.transform.position.x + ", "+ newNPC.transform.position.x );
                newNPC.GetComponent<TestNPC>().enemy = GameObject.Find("Player").GetComponent<Player>();
                newNPC.GetComponent<TestNPC>().master = GameObject.Find("FGManager").GetComponent<FGManager>();
                Debug.Log("Added Enemy: "+count);
                
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

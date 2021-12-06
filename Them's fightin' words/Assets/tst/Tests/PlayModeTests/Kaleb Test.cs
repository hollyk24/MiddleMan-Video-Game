using System.Collections;
using System.Collections.Generic;
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
        /*Tests the number of simultaneous enemies that can exist under the current system*/
        public IEnumerator NPCStressTest() {
            List<GameObject> TestNPCs = new List<GameObject>(); 
            loadTScene();
            yield return new WaitForSeconds(1);
            int count = 0;
            while((int)(1f / Time.unscaledDeltaTime) > 30) {
                //Debug.Log("Loop "+count);
                TestNPCs.Add(GameObject.Instantiate(prefab));
                Debug.Log("NPC Created: "+ count);
                /*Debug.Log("NPC x, y" + newNPC.transform.position.x + ", "+ newNPC.transform.position.x );
                newNPC.GetComponent<NPC>().enemy = GameObject.Find("Player").GetComponent<Player>();
                newNPC.GetComponent<NPC>().master = GameObject.Find("Manager").GetComponent<FGManager>();
                Debug.Log("Added Enemy: "+count);*/
                //NPCs.Add();
                //
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

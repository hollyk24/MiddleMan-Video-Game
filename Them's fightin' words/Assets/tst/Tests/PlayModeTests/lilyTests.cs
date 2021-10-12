using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using NUnit.Framework;
using UnityEngine.Tilemaps;
public class lilyTests 
{
    //[SetUp]
    public void loadScene() {
        SceneManager.LoadScene("lilyTestScene");
    }

    [UnityTest]
    /**
     * 
     * Spawn NPCs till game too slow lol
     * 
     * 
     */
    public IEnumerator NPCStressTest() {
        SceneManager.LoadScene("lilyTestScene");
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
        
    }

    [UnityTest]
    /**
     * This test makes sure NPCs dont have an overlapping interact region
     * 
     * 
     */
    public IEnumerator NPCsFarEnoughApartBoundaryTest() {
        SceneManager.LoadScene("lilyTestScene");
        yield return new WaitForSeconds(1);

        //get list
        var NPC = GameObject.FindGameObjectsWithTag("NPC");
        if (NPC.Length < 2) Assert.IsTrue(true);
        else {
            //check that no two overlap
            for(int i = 0; i < NPC.Length-1; i++) {
                for(int j = i+1; j < NPC.Length; j++) {
                    var box = NPC[i].GetComponent<Collider2D>().bounds;
                    var box2 = NPC[j].GetComponent<Collider2D>().bounds;
                    if (box.Intersects(box2)) Assert.IsTrue(false);
                }
            }
        }
        Assert.IsTrue(true);
    }

    [UnityTest]
    public IEnumerator NPCPositionBoundaryTest() {
        SceneManager.LoadScene("lilyTestScene");
        yield return new WaitForSeconds(1);

        //get list
        var NPC = GameObject.FindGameObjectsWithTag("NPC");
        var Tiles = GameObject.FindObjectOfType<Tilemap>();
        
        foreach (var n in NPC) {
            Vector3 pos = n.transform.position;
            Assert.IsTrue(Tiles.GetCellCenterWorld(Tiles.WorldToCell(pos)) != null); 
        }
    }
}

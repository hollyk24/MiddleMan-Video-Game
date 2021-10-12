using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using NUnit.Framework;
public class lilyTests 
{
    //[SetUp]
    public void loadScene() {
        SceneManager.LoadScene("lilyTestScene");
    }

    [UnityTest]
    public IEnumerator NPCStressTest() {
        SceneManager.LoadScene("lilyTestScene");
        yield return new WaitForSeconds(2);

        var NPC = GameObject.FindGameObjectWithTag("NPC");
        int count = 0;
        while((int)(1f / Time.unscaledDeltaTime) > 30) {
            GameObject.Instantiate(NPC);
            count++;
            yield return null;
        }
        Debug.LogAssertion("NPCs spawned by stress test: " + count);
    }
}

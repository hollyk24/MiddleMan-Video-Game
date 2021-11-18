using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialTiles : MonoBehaviour
{
    public string tileQualities = "This tile is as bland as it gets.";
    public virtual string getQualities()
    {
        return tileQualities;
    }
    public virtual void sayQualities()
    {
        Debug.Log(getQualities());
    }

    public IEnumerator EffectDelay(Collider2D coll)
    {
        Debug.Log("Before Wait");
        yield return new WaitForSeconds(0.2f);
        tileEffect(coll);
    }
    public virtual void tileEffect (Collider2D coll){
        Debug.Log("This effect must be overwritten.");
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        StartCoroutine(EffectDelay(coll));
        sayQualities();
    }
}

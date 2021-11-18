using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialTiles : MonoBehaviour
{
    public IEnumerator EffectDelay(Collider2D coll)
    {
        Debug.Log("Before Wait");
        yield return new WaitForSeconds(0.2f);
        tileEffect(coll);
    }
    public virtual void tileEffect (Collider2D coll){
        Debug.Log("This tile seems very special.");
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        StartCoroutine(EffectDelay(coll));
    }
}

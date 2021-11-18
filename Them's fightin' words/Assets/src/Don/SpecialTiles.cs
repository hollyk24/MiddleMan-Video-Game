using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpecialTiles : MonoBehaviour
{
    public string m_tileQualities = "This tile is as bland as it gets.";
    public virtual string GetQualities()
    {
        return m_tileQualities;
    }
    public virtual void SayQualities()
    {
        Debug.Log(GetQualities());
    }

    public IEnumerator EffectDelay(Collider2D coll)
    {
        Debug.Log("Before Wait");
        yield return new WaitForSeconds(0.2f);
        TileEffect(coll);
    }
    public virtual void TileEffect (Collider2D coll){
        
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        StartCoroutine(EffectDelay(coll));
        SayQualities();
    }
}

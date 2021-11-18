using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectPool
{
    private static int PoolSize = 8;
    private static readonly Queue Pool = new Queue(PoolSize);

    public GameObject GetObject()
    {
        GameObject Obj = null;

        if(Pool.Count > 0)
        {
            Obj = (GameObject)Pool.Dequeue();
        }
        else
        {
            if(Pool.Count >= PoolSize)
            {
                Debug.Log("The object pool is full. Please reuse another object.");
            }
            else
            {
                Obj = new GameObject("Pool Object");
                Obj.tag = "Pool Object";
                Obj.AddComponent<AudioSource>();
            }
           
        }
        return Obj;
    }

    public void RecycleObject(GameObject RecycledObject)
    {
        RecycledObject.GetComponent<AudioSource>().clip = null;
        Pool.Enqueue(RecycledObject);
    }

}

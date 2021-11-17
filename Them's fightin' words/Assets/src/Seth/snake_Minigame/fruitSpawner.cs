using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitSpawner : MonoBehaviour
{
    [SerializeField] private GameObject snake_fruitPrefab;
    [SerializeField] private GameObject snake_fruitPrefabYellow;
    public bool spawnFruit = true;
    // Start is called before the first frame update
    void Awake()
    {
        // spawnFruit = true;
        StartCoroutine(fruitSpawnerLoop());
    }

    // Update is called once per frame
    public IEnumerator fruitSpawnerLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.25f);
            if (spawnFruit)
            {
                spawnFruit = false;
                float randNum = Mathf.Round(Random.Range(0, 10));
                if (randNum < 7)
                {
                    Instantiate(snake_fruitPrefab, new Vector3(Mathf.Round(Random.Range(-8, 7)), Mathf.Round(Random.Range(-5, 4)), -4), Quaternion.identity, this.transform);

                }
                else
                {
                    Instantiate(snake_fruitPrefabYellow, new Vector3(Mathf.Round(Random.Range(-8, 7)), Mathf.Round(Random.Range(-5, 4)), -4), Quaternion.identity, this.transform);
                }
                // newFruit.transform.SetParent(this.transform);
            }
        }
    }

    public void fruitNeedsSpawned()
    {
        spawnFruit = true;
    }
}

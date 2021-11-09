using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{
    // [SerializeField] private GameObject snakeHead;
    [SerializeField] private GameObject snakeBodyPrefab;
    private bool isTail = true;
    public Vector3 lastPosition;
    private GameObject snakeChild;
    // public SnakeTail(Vector2 pos)
    // {
    // transform.position = pos;
    // }
    void Start()
    {
        if (transform.parent != null)
        {
            StartCoroutine(snakeBodyMovement());
        }
        else { isTail = false; };
    }
    public void AddSegment()
    {
        if (isTail)
        {
            // Add new tail here
            isTail = false;
            snakeChild = Instantiate(snakeBodyPrefab, new Vector3(lastPosition.x,lastPosition.y,0), Quaternion.identity) as GameObject;
            snakeChild.transform.SetParent(transform);
            // } else (snakeChild.SnakeTail.AddSegment());
        }
    }
    // Update is called once per frame
    // void Update()
    // {

    // }

    public IEnumerator snakeBodyMovement()
    {
        yield return new WaitForSeconds(0.3f);
        while (transform.root.GetComponent<snakeHead>().gameOver == false)
        {
            lastPosition = transform.position;
            // Debug.Log("lastPosition:  " + lastPosition.ToString());
            transform.position = transform.parent.GetComponent<SnakeTail>().lastPosition;
            yield return new WaitForSeconds(0.6f);
        }
    }
}

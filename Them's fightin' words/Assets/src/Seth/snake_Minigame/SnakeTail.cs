using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{
    [SerializeField] private GameObject snakeBodyPrefab;
    SnakeManager SM;
    public bool isTail = false;
    public bool gameStarted = false;
    public Vector3 lastPosition;
    [SerializeField] public GameObject prevSegment;
    [SerializeField] public GameObject nextSegment;
    [SerializeField] public GameObject Snake;
    public SnakeTail nextSegmentTailCode;
    void Start()
    {
        SM = GetComponentInParent<SnakeManager>();

        if (nextSegment == null)
        {
            isTail = true;
            transform.position = prevSegment.GetComponent<SnakeTail>().lastPosition;
        }
        else
        {
            isTail = false;
            nextSegmentTailCode = nextSegment.GetComponent<SnakeTail>();
        }
        StartCoroutine(gameStartTimer());
    }
    public void AddSegment()
    {
        if (isTail)
        {
            isTail = false;
            nextSegment = Instantiate(snakeBodyPrefab, new Vector3(lastPosition.x, lastPosition.y, -2), Quaternion.identity) as GameObject;
            nextSegmentTailCode = nextSegment.GetComponent<SnakeTail>();
            nextSegmentTailCode.prevSegment = prevSegment.GetComponent<SnakeTail>().nextSegment;
            nextSegment.transform.SetParent(Snake.transform);
        }
        else
        {
            nextSegmentTailCode.AddSegment();
        }
    }
    public void moveSegment()
    {
        lastPosition = transform.position;
        if (prevSegment != null)
            transform.position = prevSegment.GetComponent<SnakeTail>().lastPosition;
        if (!isTail)
            nextSegment.GetComponent<SnakeTail>().moveSegment();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if((col.gameObject.tag == "snake_Body" || col.gameObject.tag == "snake_Wall")&&(gameStarted == true)){
            StartCoroutine(SM.GAMEOVER());
        }   
        Debug.Log("OnTriggerEnter2D: " + col.gameObject.tag); // Tells you what was collided with, for debugging
    }
    public IEnumerator gameStartTimer(){
        // Fixes an issue with the game during runtime where the OnTriggerEnter would immediately trigger a gameOver
        yield return new WaitForSeconds(1);
        gameStarted = true;
    }
}

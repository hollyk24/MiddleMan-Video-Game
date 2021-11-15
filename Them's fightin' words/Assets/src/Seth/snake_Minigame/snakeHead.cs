using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class snakeHead : MonoBehaviour
{
    private SnakeManager SM;
    private Controls controls;
    private SnakeTail tailCode;
    private SnakeTail tailCodeNext;
    public int SnakeTailQueue = 3;
    private int Direction = 0;
    private int PrevDir = 0;
    // 0:Up 1:Down 2:Left 3:Right

    InputAction UpInput, DownInput, LeftInput, RightInput;
    void Start()
    {
        SM = transform.parent.GetComponent<SnakeManager>();
        controls = SnakeManager.CONTROLS;

        UpInput = controls.minigame_snake.Up;
        DownInput = controls.minigame_snake.Down;
        LeftInput = controls.minigame_snake.Left;
        RightInput = controls.minigame_snake.Right;

        UpInput.performed += faceUp;
        DownInput.performed += faceDown;
        LeftInput.performed += faceLeft;
        RightInput.performed += faceRight;

        UpInput.Enable();
        DownInput.Enable();
        LeftInput.Enable();
        RightInput.Enable();

        // Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        tailCode = gameObject.GetComponent<SnakeTail>();
        tailCode.lastPosition = transform.position;
        // tailCode.isTail = false;
        tailCodeNext = tailCode.nextSegment.GetComponent<SnakeTail>();
        StartCoroutine(movementListener());
        // StartCoroutine(addSegmentLoop());
    }
    private void OnDestroy()
    {
        UpInput.performed -= faceUp;
        DownInput.performed -= faceDown;
        LeftInput.performed -= faceLeft;
        RightInput.performed -= faceRight;
    }

    private void faceUp(InputAction.CallbackContext context)
    {
        if ((Direction == 2 || Direction == 3) && PrevDir != 1)
            Direction = 0;
    }
    private void faceDown(InputAction.CallbackContext context)
    {
        if ((Direction == 2 || Direction == 3) && PrevDir != 0)
            Direction = 1;
    }
    private void faceLeft(InputAction.CallbackContext context)
    {
        if ((Direction == 0 || Direction == 1) && PrevDir != 3)
            Direction = 2;
    }
    private void faceRight(InputAction.CallbackContext context)
    {
        if ((Direction == 0 || Direction == 1) && PrevDir != 2)
            Direction = 3;
    }

    private void moveSnake(int Dir)
    {
        Vector3 pos = transform.position;
        switch (Dir)
        {
            case 0:
                PrevDir = 0;
                transform.position = pos + new Vector3(0, 1, 0);
                break;
            case 1:
                PrevDir = 1;
                transform.position = pos + new Vector3(0, -1, 0);
                break;
            case 2:
                PrevDir = 2;
                transform.position = pos + new Vector3(-1, 0, 0);
                break;
            case 3:
                PrevDir = 3;
                transform.position = pos + new Vector3(1, 0, 0);
                break;
            default:
                break;
        }
        if(SnakeTailQueue > 0){
            SnakeTailQueue--;
            SM.LengthenSnake();
            Debug.Log("Lengthening Snake");
        }
    }

    public IEnumerator movementListener()
    {
        // yield return new WaitForSeconds(2);
        while (SM.GameOver != true)
        {
            // Debug.Log("Direction:  " + Direction.ToString());
            tailCode.lastPosition = transform.position;
            moveSnake(Direction);
            tailCodeNext.moveSegment();
            yield return new WaitForSeconds(0.25f);
        }
    }
    public void addSnakeSegment()
    {
        tailCodeNext.AddSegment();
    }
}

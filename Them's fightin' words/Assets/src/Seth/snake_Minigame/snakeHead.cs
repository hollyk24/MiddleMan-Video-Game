using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class snakeHead : MonoBehaviour
{
    private Controls controls;
    private SnakeTail tailCode;
    public bool gameOver = false;
    private int Direction = 0;
    private int PrevDir = 0;
    // 0:Up 1:Down 2:Left 3:Right
    [SerializeField] private GameObject gameOverPanel;
    InputAction UpInput, DownInput, LeftInput, RightInput;
    void Start()
    {
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

        // gameObject.AddComponent<BoxCollider2D>();
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        tailCode = gameObject.GetComponent<SnakeTail>();
        tailCode.lastPosition = transform.position;
        StartCoroutine(movementListener());
    }
    private void OnDestroy()
    {
        UpInput.performed -= faceUp;
        DownInput.performed -= faceDown;
        LeftInput.performed -= faceLeft;
        RightInput.performed -= faceRight;
    }

    // void OnTriggerEnter2D(Collider2D col)
    // // void OnTriggerExit2D(Collider2D col)
    // {
    //     Debug.Log("OnTriggerExit2D");
    //     gameOver = true;
    //     gameOverPanel.SetActive(true);
    // }

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
        // Debug.Log(pos.ToString());
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
    }

    public IEnumerator movementListener()
    {
        while (gameOver != true)
        {
            // Debug.Log("Direction:  " + Direction.ToString());
            tailCode.lastPosition = transform.position;
            moveSnake(Direction);
            yield return new WaitForSeconds(0.25f);
        }
    }
}

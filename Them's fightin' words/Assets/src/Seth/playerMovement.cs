using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    public float speed = 1f;
    private float speedMultiplier = 1;
    private Controls controls;
    private Transform target;
    private bool movementLock = false;
    private bool autoMoveLock = false;


    InputAction UpInput, DownInput, LeftInput, RightInput, runToggleInput;
    private void Start()
    {
        // Debug.Log("In Start function");
        controls = GameManager.CONTROLS;

        UpInput = controls.Player.moveUp;
        DownInput = controls.Player.moveDown;
        LeftInput = controls.Player.moveLeft;
        RightInput = controls.Player.moveRight;
        runToggleInput = controls.Player.Run;

        UpInput.performed += moveUp;
        DownInput.performed += moveDown;
        LeftInput.performed += moveLeft;
        RightInput.performed += moveRight;
        runToggleInput.performed += runToggle;

        UpInput.Enable();
        DownInput.Enable();
        LeftInput.Enable();
        RightInput.Enable();
        runToggleInput.Enable();
    }

    public void moveUp(InputAction.CallbackContext context)
    {
        if (context.performed == true && movementLock == false)
        {
            movementLock = true;
            StartCoroutine(movePlayerTowards(transform.position + new Vector3(0, 1, 0)));
        }
    }
    public void moveDown(InputAction.CallbackContext context)
    {
        if (context.performed == true && movementLock == false)
        {
            movementLock = true;
            StartCoroutine(movePlayerTowards(transform.position + new Vector3(0, -1, 0)));
        }
    }
    public void moveLeft(InputAction.CallbackContext context)
    {
        if (context.performed == true && movementLock == false)
        {
            movementLock = true;
            StartCoroutine(movePlayerTowards(transform.position + new Vector3(-1, 0, 0)));
        }
    }
    public void moveRight(InputAction.CallbackContext context)
    {
        if (context.performed == true && movementLock == false)
        {
            movementLock = true;
            StartCoroutine(movePlayerTowards(transform.position + new Vector3(1, 0, 0)));
        }
    }

    public IEnumerator movePlayerTowards(Vector3 end)
    {
        AudioManager.Play(AudioLibrary.Library.Move);
        while (transform.position != end)
        {
            transform.position = Vector3.MoveTowards(transform.position, end, speed * Time.deltaTime * speedMultiplier);
            yield return null;
        }
        movementLock = false;
    }
    public void runToggle(InputAction.CallbackContext context)
    {
        if (speedMultiplier == 1)
            speedMultiplier = 2;
        else
            speedMultiplier = 1;
        // autoMoveLoop();
    }
    public void setSpeed(float s){
        speedMultiplier = s;
    }
    // For Testing
    public void autoMoveLoop(){
        if(autoMoveLock == false){
            setSpeed(10);
            autoMoveLock = true;
            InvokeRepeating("autoMove", 0.2f, 0.2f);
        } else {
            setSpeed(1);
            CancelInvoke("autoMove");
            autoMoveLock = false;
        }
    }
    public void autoMove()
    {
        AudioManager.Play(AudioLibrary.Library.Move);
        int rand = Random.Range(0, 3);
        switch (rand)
        {
            case 0:
                if (movementLock == false)
                {
                    movementLock = true;
                    StartCoroutine(movePlayerTowards(transform.position + new Vector3(0, 1, 0)));
                }
                break;
            case 1:
                if (movementLock == false)
                {
                    movementLock = true;
                    StartCoroutine(movePlayerTowards(transform.position + new Vector3(0, -1, 0)));
                }
                break;
            case 2:
                if (movementLock == false)
                {
                    movementLock = true;
                    StartCoroutine(movePlayerTowards(transform.position + new Vector3(1, 0, 0)));
                }
                break;
            case 3:
                if (movementLock == false)
                {
                    movementLock = true;
                    StartCoroutine(movePlayerTowards(transform.position + new Vector3(-1, 0, 0)));
                }
                break;
            default:
                break;
        }
    }
}
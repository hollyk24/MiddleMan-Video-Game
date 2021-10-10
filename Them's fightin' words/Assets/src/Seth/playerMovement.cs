using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    private const bool V = false;
    public float speed = 1f;
    public float speedMultiplier = 1;
    private Controls controls;
    private Transform target;
    private bool movementLock = false;


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
    }

    public void moveUp(InputAction.CallbackContext context)
    {
        if (context.started == true && movementLock != true){
            // StopAllCoroutines();
            movementLock = true;
            StartCoroutine(movePlayerTowards(transform.position + new Vector3(0, 1, 0)));
        }
        // Debug.Log(context);
        // Debug.Log("Moving Up");
    }
    public void moveDown(InputAction.CallbackContext context)
    {
        if (context.started == true && movementLock != true){
            // StopAllCoroutines();
            movementLock = true;
            StartCoroutine(movePlayerTowards(transform.position + new Vector3(0, -1, 0)));
        }
    }
    public void moveLeft(InputAction.CallbackContext context)
    {
        if (context.started == true && movementLock != true){
            // StopAllCoroutines();
            movementLock = true;
            StartCoroutine(movePlayerTowards(transform.position + new Vector3(-1, 0, 0)));
        }
    }
    public void moveRight(InputAction.CallbackContext context)
    {
        if (context.started == true && movementLock != true){
            // StopAllCoroutines();
            movementLock = true;
            StartCoroutine(movePlayerTowards(transform.position + new Vector3(1, 0, 0)));
        }
    }

    public IEnumerator movePlayerTowards(Vector3 end)
    {
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
    }
}
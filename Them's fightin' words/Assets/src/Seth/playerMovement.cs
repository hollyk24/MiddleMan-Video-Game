﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    public float speed = 1f;
    private float speedMultiplier = 1;
    private Controls controls;
    private Transform target;

    private bool movementLock = false;
    private bool autoMoveLock = false;

    Animator animator;
    LocTests tileChecks;

    Vector3 dir = Vector3.zero;
    //

    // Make it move X meters per second instead of X meters per frame...
    // dir *= Time.deltaTime;

    // Move object
    // transform.Translate(dir * speed);
    //


    InputAction UpInput, DownInput, LeftInput, RightInput, runToggleInput;
    void Awake()
    {
        StartCoroutine(motionControls());
    }
    private void Start()
    {
        animator = GetComponent<Animator>();
        tileChecks = GetComponent<LocTests>();
        // walkMap = GetComponent<Walkmap>().Tilemap;
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

    void FixedUpdate()
    {
        dir.x = Input.acceleration.x;
        dir.y = Input.acceleration.y;
        // Debug.Log(dir.x.ToString());

        // clamp acceleration vector to the unit sphere
        if (dir.sqrMagnitude > 1)
            dir.Normalize();
    }

    private void OnDestroy()
    {
        UpInput.performed -= moveUp;
        DownInput.performed -= moveDown;
        LeftInput.performed -= moveLeft;
        RightInput.performed -= moveRight;
        runToggleInput.performed -= runToggle;
    }
    public void moveUp(InputAction.CallbackContext context)
    {
        if (context.performed == true && movementLock == false)
        {
            animator.SetTrigger("up");
            movementLock = true;
            StartCoroutine(movePlayerTowards(transform.position + new Vector3(0, 1, 0)));
        }
    }
    public void moveDown(InputAction.CallbackContext context)
    {
        if (context.performed == true && movementLock == false)
        {
            animator.SetTrigger("down");
            movementLock = true;
            StartCoroutine(movePlayerTowards(transform.position + new Vector3(0, -1, 0)));
        }
    }
    public void moveLeft(InputAction.CallbackContext context)
    {
        if (context.performed == true && movementLock == false)
        {
            animator.SetTrigger("left");
            movementLock = true;
            StartCoroutine(movePlayerTowards(transform.position + new Vector3(-1, 0, 0)));
        }
    }
    public void moveRight(InputAction.CallbackContext context)
    {
        if (context.performed == true && movementLock == false)
        {
            animator.SetTrigger("right");
            movementLock = true;
            StartCoroutine(movePlayerTowards(transform.position + new Vector3(1, 0, 0)));
        }
    }

    public IEnumerator movePlayerTowards(Vector3 end)
    {
        AudioManager.Play(AudioLibrary.Library.Move);
        if (tileChecks.checkWalkable(end + new Vector3(0, -0.5f, 0)))
        {
            animator.SetBool("Walking", true);
            while (transform.position != end)
            {
                transform.position = Vector3.MoveTowards(transform.position, end, speed * Time.deltaTime * speedMultiplier);
                yield return null;
            }
            animator.SetBool("Walking", false);
        }
        movementLock = false;
    }

    public void runToggle(InputAction.CallbackContext context)
    {
        if (speedMultiplier == 1)
            speedMultiplier = 3;
        else
            speedMultiplier = 1;
        setSpeed(1f);
        autoMoveLoop();
        // Instantiate(this);
    }

    public void cloneThisObject()
    {
        transform.DetachChildren();
        Instantiate(this);
    }
    public void setSpeed(float s)
    {
        speedMultiplier = s;
    }
    // For Testing
    public void autoMoveLoop()
    {
        if (autoMoveLock == false)
        {
            setSpeed(1);
            autoMoveLock = true;
            InvokeRepeating("autoMove", 0.000011f, 0.000011f);
        }
        else
        {
            setSpeed(1);
            CancelInvoke("autoMove");
            autoMoveLock = false;
        }
    }
    public void autoMoveSetSpeed(float sm)
    {
        speedMultiplier = sm;
        autoMove();
    }

    public void autoMove()
    {
        if (movementLock == false)
        {
            movementLock = true;
            animator.SetBool("Walking", true);
            AudioManager.Play(AudioLibrary.Library.Move);
            int rand = Random.Range(0, 4);
            // Debug.Log("Actual " + 10*transform.position.x);
            // Debug.Log("Round " + Mathf.Round(10*transform.position.x));
            // Debug.Log("Centered on tile: "+ Mathf.Approximately((10*transform.position.x)-Mathf.Round(10*transform.position.x),0));
            switch (rand)
            {
                case 0:
                    animator.SetTrigger("up");
                    StartCoroutine(movePlayerTowards(transform.position + new Vector3(0, 1, 0)));
                    break;
                case 1:
                    animator.SetTrigger("down");
                    StartCoroutine(movePlayerTowards(transform.position + new Vector3(0, -1, 0)));
                    break;
                case 2:
                    animator.SetTrigger("right");
                    StartCoroutine(movePlayerTowards(transform.position + new Vector3(1, 0, 0)));
                    break;
                case 3:
                    animator.SetTrigger("left");
                    StartCoroutine(movePlayerTowards(transform.position + new Vector3(-1, 0, 0)));
                    break;
                default:
                    break;
            }
            animator.SetBool("Walking", false);
        }
    }

    public void debugOut(string s)
    {
        Debug.Log(s);
    }

    IEnumerator motionControls()
    {
        yield return new WaitForSeconds(0.25f);
        while (true)
        {
            // Debug.Log(movementLock == true ? 1 : 0);
            if (movementLock == false)
            {
                // Debug.Log(dir.x);
                movementLock = true;
                // Debug.Log(dir.ToString());
                if (Mathf.Abs(dir.x) >= 0.125)
                {
                    if (dir.x > 0.125)
                    {
                        animator.SetTrigger("right");
                        // Debug.Log("dir.x is greater than 0");
                        StartCoroutine(movePlayerTowards(transform.position + new Vector3(1, 0, 0)));
                    }
                    else if (dir.x < -0.125)
                    {
                        animator.SetTrigger("left");
                        // Debug.Log("dir.x is less than 0");
                        StartCoroutine(movePlayerTowards(transform.position + new Vector3(-1, 0, 0)));
                    }
                }
                else
                {
                    if (dir.y > -0.3)
                    {
                        animator.SetTrigger("up");
                        StartCoroutine(movePlayerTowards(transform.position + new Vector3(0, 1, 0)));
                    }
                    else if (dir.y < -0.5)
                    {
                        animator.SetTrigger("down");
                        StartCoroutine(movePlayerTowards(transform.position + new Vector3(0, -1, 0)));
                    }
                }
                yield return new WaitForSeconds(0.325f);
                movementLock = false;
            }
        }
    }
}
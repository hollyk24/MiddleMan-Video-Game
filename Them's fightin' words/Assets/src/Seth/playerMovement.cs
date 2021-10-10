using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float speedMultiplier = 1;
    private Controls controls;


    InputAction UpInput, DownInput, LeftInput, RightInput, runToggleInput;
    private void Start()
    {
        Debug.Log("In Start function");
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
        transform.Translate(Vector3.up * speed * Time.deltaTime * speedMultiplier);
        // Debug.Log(context);
        // Debug.Log("Moving Up");
    }
    public void moveDown(InputAction.CallbackContext context)
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime * speedMultiplier);
    }
    public void moveLeft(InputAction.CallbackContext context)
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime * speedMultiplier);
    }
    public void moveRight(InputAction.CallbackContext context)
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime * speedMultiplier);
    }
    public void runToggle(InputAction.CallbackContext context)
    {
        if (speedMultiplier == 1)
            speedMultiplier = 1.5F;
        else
            speedMultiplier = 1;
    }

    // void Start(){
    //     // transform.position = new Vector3(0,0,0);
    // }
}
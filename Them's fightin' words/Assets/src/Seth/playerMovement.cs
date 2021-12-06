using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    private static playerMovement instance;
    public float speed = 1f;
    private float speedMultiplier = 1;
    private Controls controls;
    private Transform target;

    private bool movementLock = false;
    private bool autoMoveLock = false;
    [SerializeField] private GameObject IM;
    [SerializeField] private SaveManager SM;
    Animator animator;
    LocTests tileChecks;

    // movementTracker_singleton movementTracker;

    InputAction UpInput, DownInput, LeftInput, RightInput, runToggleInput, InventoryInput;

    public static playerMovement Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<playerMovement>();
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(playerMovement).Name;
                    instance = obj.AddComponent<playerMovement>();
                }
            }
            return instance;
        }
    }
    private void Awake()
    {

        // This section keeps only one playerMovement script in existence at all times
        if (instance == null)
        {
            instance = this as playerMovement;
            // DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        animator = GetComponent<Animator>();
        tileChecks = GetComponent<LocTests>();
        SM = GameObject.Find("SaveManager").GetComponent<SaveManager>();
        // movementTracker = GetComponent<movementTracker_singleton>();
        // walkMap = GetComponent<Walkmap>().Tilemap;
        // Debug.Log("In Start function");
        controls = GameManager.CONTROLS;

        UpInput = controls.Player.moveUp;
        DownInput = controls.Player.moveDown;
        LeftInput = controls.Player.moveLeft;
        RightInput = controls.Player.moveRight;
        runToggleInput = controls.Player.Run;
        InventoryInput = controls.Player.Inventory;

        UpInput.performed += moveUp;
        DownInput.performed += moveDown;
        LeftInput.performed += moveLeft;
        RightInput.performed += moveRight;
        runToggleInput.performed += runToggle;
        InventoryInput.performed += inventoryToggle;

        UpInput.Enable();
        DownInput.Enable();
        LeftInput.Enable();
        RightInput.Enable();
        runToggleInput.Enable();
        InventoryInput.Enable();
        // SceneManager.sceneLoaded += setupMap;
    }
    private void OnDestroy()
    {
        UpInput.performed -= moveUp;
        DownInput.performed -= moveDown;
        LeftInput.performed -= moveLeft;
        RightInput.performed -= moveRight;
        runToggleInput.performed -= runToggle;
        InventoryInput.performed -= inventoryToggle;
        // SceneManager.sceneLoaded -= setupMap;

    }

    // public void setupMap(Scene scene, LoadSceneMode mode)
    // {
    //     Debug.Log("Scene Loaded");
    //     transform.position = SM.savedPosition;
    // }
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
            SM.setPosition(end);
            // SM.setDirection()
            animator.SetBool("Walking", true);
            // movementTracker.UpdatePlayerLocation(end.x, end.y);
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
        // setSpeed(1f);
        // autoMoveLoop();
        // Instantiate(this);
    }

    public void inventoryToggle(InputAction.CallbackContext context)
    {
        IM.SetActive(!IM.activeInHierarchy);
        // Debug.Log("timeScale = " + Time.timeScale);
        // Debug.Log("timeScale = " + Time.timeScale);
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
        // Time.fixedTimeDelta = this.fixedDeltaTime * Time.timeScale;
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
            // movementTracker.playerLocation = new Vector3(0, 0, 0);
            animator.SetBool("Walking", false);
        }
    }

    public void debugOut(string s)
    {
        Debug.Log(s);
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveManager : MonoBehaviour
{
    private static SaveManager instance;
    public GameObject gameWonUI;
    [SerializeField] public Vector3 savedPosition;
    private WinTracker WT;
    private Transform playerTransform;

    public void setupReferences()
    {
        WT = GetComponent<WinTracker>();
        gameWonUI = GameObject.FindGameObjectWithTag("GameWonUI");
        gameWonUI.SetActive(false);
    }
    public void setPosition(Vector3 v)
    {
        savedPosition = v;
    }
    public Vector3 getPosition()
    {
        return savedPosition;
    }

    public static SaveManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SaveManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(SaveManager).Name;
                    instance = obj.AddComponent<SaveManager>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this as SaveManager;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void OnEnable()
    {
        SceneManager.sceneLoaded += setupMap;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= setupMap;
    }

    public void setupMap(Scene scene, LoadSceneMode mode)
    {
        setupReferences();
        if (scene.name == "overWorld")
        {
            playerTransform = GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Transform>();
            if (playerTransform == null) Debug.Log("Could not find player");
            playerTransform.position = savedPosition;
            if (WT.checkWins())
            {
                // Time.timeScale = 0;
                gameWonUI.SetActive(true);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocationManager : MonoBehaviour
{
    private static LocationManager instance;
    [SerializeField] public Vector3 savedPosition;
    private Transform playerTransform;
    public void setPosition(Vector3 v)
    {
        savedPosition = v;
    }
    public Vector3 getPosition()
    {
        return savedPosition;
    }

    public static LocationManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<LocationManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(LocationManager).Name;
                    instance = obj.AddComponent<LocationManager>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this as LocationManager;
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

    void OnDisable(){
        SceneManager.sceneLoaded -= setupMap;
    }

    public void setupMap(Scene scene, LoadSceneMode mode){
        if(scene.name == "overWorld"){
            playerTransform = GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Transform>();
            if(playerTransform == null) Debug.Log("Could not find player");
            playerTransform.position = savedPosition;
        }
    }
}

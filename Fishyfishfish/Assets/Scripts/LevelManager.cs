using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //access from anywhere
    public static LevelManager instance;
    //set a respawn point
    public Transform respawnPoint;
    public GameObject playerPrefab;


    private void Awake()
    {
        instance = this;
    }
    
    public void Respawn()
    {
        Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
    }
}

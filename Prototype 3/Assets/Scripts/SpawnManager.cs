using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    public float startDelay = 2;
    public float repeatRate = 2;
    private PlayerController playerControllerScript;
    public GameObject pauseScreen;
    public GameObject gameOverScreen;
    //public GameObject playerPrefab;

    public bool gamePaused;
    
    // Start is called before the first frame update
    void Awake()
    {
        Time.timeScale = 1;
        //Instantiate(playerPrefab, playerPrefab.transform.position, playerPrefab.transform.rotation);
        //playerControllerScript = playerPrefab.GetComponent<PlayerController>();
        //playerControllerScript.gameOver = false;
        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !playerControllerScript.gameOver)
        {
            if (!gamePaused)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }

        if(playerControllerScript.gameOver)
        {
            pauseScreen.gameObject.SetActive(false);
            gameOverScreen.SetActive(true);
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        gamePaused = true;
        pauseScreen.gameObject.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        gamePaused = false;
        pauseScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void SpawnObstacle()
    {
        if (!playerControllerScript.gameOver)
        {
            int i = Random.Range(0, obstaclePrefab.Length);
            Instantiate(obstaclePrefab[i], spawnPos, obstaclePrefab[i].transform.rotation);
        }
    }
}

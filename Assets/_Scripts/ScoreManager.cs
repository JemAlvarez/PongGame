using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] int aiScore = 0;
    [SerializeField] int playerScore = 0;
    [SerializeField] int maxScore = 10;
    public bool playerWins = false;

    private void Awake()
    {
        SetUpSingleton();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameOver();
    }

    public void AddScore(string player)
    {
        if (player == "player")
        {
            playerScore++;
        }
        else if (player == "ai")
        {
            aiScore++;
        }
    }

    public void ResetScores()
    {
        playerScore = 0;
        aiScore = 0;
    }

    public  int GetScore(string player = "")
    {
        if (player == "ai")
        {
            return aiScore;
        }

        return playerScore;
    }

    void GameOver()
    {
        if (SceneManager.GetActiveScene().name == "Game")
        {
            if (aiScore >= maxScore)
            {
                playerWins = false;
                FindObjectOfType<SceneLoader>().LoadEndScreen();
            }
            else if (playerScore >= maxScore)
            {
                playerWins = true;
                FindObjectOfType<SceneLoader>().LoadEndScreen();
            }
        }
    }

    private void SetUpSingleton()
    {
        int numberofSessions = FindObjectsOfType<ScoreManager>().Length;
        if (numberofSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }


}

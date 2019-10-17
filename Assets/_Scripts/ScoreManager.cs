using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI aiScoreText;
    [SerializeField] TextMeshProUGUI playerScoreText;
    [SerializeField] int aiScore = 0;
    [SerializeField] int playerScore = 0;
    bool playerWins = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayScore();
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

    public  int GetScore(string player)
    {
        if (player == "ai")
        {
            return aiScore;
        }

        return playerScore;
    }

    void DisplayScore()
    {
        aiScoreText.text = aiScore.ToString();
        playerScoreText.text = playerScore.ToString();
    }

    void GameOver()
    {
        if (aiScore >= 10)
        {
            playerWins = false;
            FindObjectOfType<SceneLoader>().LoadEndScreen();
        }
        else if (playerScore >= 10)
        {
            playerWins = true;
            FindObjectOfType<SceneLoader>().LoadEndScreen();
        }
    }
}

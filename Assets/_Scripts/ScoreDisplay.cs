using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI aiScoreText;
    [SerializeField] TextMeshProUGUI playerScoreText;
    int aiScore;
    int playerScore;

    ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        aiScore = scoreManager.GetScore("ai");
        playerScore = scoreManager.GetScore();
        DisplayScore();
    }

    void DisplayScore()
    {
        aiScoreText.text = aiScore.ToString();
        playerScoreText.text = playerScore.ToString();
    }
}

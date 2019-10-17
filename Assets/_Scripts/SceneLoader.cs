using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    public void LoadStart()
    {
        SceneManager.LoadScene("Start");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
        scoreManager.ResetScores();
    }

    public void LoadEndScreen()
    {
        SceneManager.LoadScene("End");
    }

    public void Quit()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int lives;
    private int score;
    public Text livestext;
    public Text scoretext;

    [HideInInspector]
    public int numberOfBricks;

    [HideInInspector]
    public bool gameOver;

    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        livestext.text = "Lives: " + lives;
        scoretext.text = "Score: " + score;
        numberOfBricks = GameObject.FindGameObjectsWithTag("Brick").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLives(int changeInLives)
    {
        lives += changeInLives;

        if(lives <= 0)
        {
            lives = 0;
            GameOver();
        }

        livestext.text = "Lives: " + lives;
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoretext.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void UpdateNumberOfBricks()
    {
        numberOfBricks--;
        if (numberOfBricks <= 0)
            GameOver();
    }
}

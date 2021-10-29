using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int lives;
    private int score;
    public Text livestext;
    public Text scoretext;

    // Start is called before the first frame update
    void Start()
    {
        livestext.text = "Lives: " + lives;
        scoretext.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLives(int changeInLives)
    {
        lives += changeInLives;



        livestext.text = "Lives: " + lives;
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoretext.text = "Score: " + score;
    }
}

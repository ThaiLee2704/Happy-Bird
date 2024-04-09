using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public static Logic Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    [SerializeField] int playerScore;
    [SerializeField] Text scoreText;
    [SerializeField] GameObject bird;
    [SerializeField] GameObject gameOverScreen;
    private bool isLive = true;
    public bool IsLive => isLive;
    
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Pipe"))
        {
            Destroy(bird);
            isLive = false;
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}

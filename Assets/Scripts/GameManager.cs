using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject gameOverMenu;
    Score score;
    void Start() 
    {
        //включаем скрипт в начале игры чтобы управлять им
        score = GetComponent<Score>();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    public void EndGame()
    {
        gameOverMenu.SetActive(true);
        score.SetBestScore();
    }
}

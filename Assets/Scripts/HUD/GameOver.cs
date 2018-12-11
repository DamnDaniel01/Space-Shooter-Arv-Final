using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene(0);

        Time.timeScale = 1;

        Score.scoreValue = 0;
    }

    public void QuitLevel()
    {
        Application.Quit();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

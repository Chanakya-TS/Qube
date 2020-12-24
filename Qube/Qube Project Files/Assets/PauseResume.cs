using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseResume : MonoBehaviour
{
    bool isPaused = false;
    
    public void pauseGame()
    {
        if(isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        } else
        {
            Time.timeScale = 0;
            isPaused = true;
        }

    }

    public void resetGame()
    {
        SceneManager.LoadScene(0);
    }
}

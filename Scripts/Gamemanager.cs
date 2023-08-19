
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public GameObject CompleteLevelUI;
    bool GameHasEnded = false;
    public float RestartDelay = 3;
    
    
    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }
    public void EndGame()   
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game has Ended !");
            Invoke("Restart", RestartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

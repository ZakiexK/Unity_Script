using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.VFX;

public class MenuStart : MonoBehaviour
{
    public void menustart()
    {
        Debug.Log("Starting the Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Debug.Log("QUIT");
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void throwback() 
    {
        SceneManager.LoadScene(0);
    }
}


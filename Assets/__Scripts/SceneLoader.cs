using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadProspector()
    {
        SceneManager.LoadScene("__Prospector_Scene_0");
    }

    public void LoadGolf()
    {
        SceneManager.LoadScene("Golf");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
} 
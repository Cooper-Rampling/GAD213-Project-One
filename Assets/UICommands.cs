using UnityEngine;
using UnityEngine.SceneManagement;

public class UICommands : MonoBehaviour
{

    public void LevelSelect()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Options() 
    { 
        SceneManager.LoadScene(3); 
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}

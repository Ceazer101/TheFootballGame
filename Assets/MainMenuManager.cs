using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level_1"); // Replace "Level1" with the name of your first level scene.
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

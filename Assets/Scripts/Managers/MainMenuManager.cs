using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject storyPanel;
    [SerializeField] string mainLevelSceneName = "MainLevel";

    public void StartEndless()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainLevelSceneName);
    }

    public void ShowStory()
    {
        mainPanel.SetActive(false);
        storyPanel.SetActive(true);
    }

    public void ReturnToMain()
    {
        storyPanel.SetActive(false);
        mainPanel.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

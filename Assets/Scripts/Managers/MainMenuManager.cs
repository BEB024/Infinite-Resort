using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject storyPanel;
    [SerializeField] GameObject optionsPanel;
    [SerializeField] GameObject levelsPanel;
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

    public void ShowOptions()
    {
        mainPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }

    public void ShowLevels()
    {
        mainPanel.SetActive(false);
        levelsPanel.SetActive(true);
    }

    public void ReturnToMain()
    {
        storyPanel.SetActive(false);
        optionsPanel.SetActive(false);
        levelsPanel.SetActive(false);
        mainPanel.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

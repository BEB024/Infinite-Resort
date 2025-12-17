using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject storyPanel;
    [SerializeField] GameObject optionsPanel;
    [SerializeField] GameObject levelsPanel;
    [SerializeField] string mainLevelSceneName = "MainLevel";
    [SerializeField] string easyLevelSceneName = "EasyLevel";
    [SerializeField] string mediumLevelSceneName = "MediumLevel";
    [SerializeField] string hardLevelSceneName = "HardLevel";

    public void StartEndless()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainLevelSceneName);
    }

    public void StartEasy()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(easyLevelSceneName);
    }

    public void StartMedium()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mediumLevelSceneName);
    }

    public void StartHard()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(hardLevelSceneName);
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

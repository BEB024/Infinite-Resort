using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    [Header("References")]
    public AudioMixer audioMixer;
    public TMP_Dropdown resolutionDropdown;
    public GameSettingsSO gameSettings;

    Resolution[] resolutions;

    void Start()
    {
        // -------- RESOLUTIONS --------
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
        }

        resolutionDropdown.AddOptions(options);

        // Clamp in case resolutions change
        gameSettings.resolutionIndex = Mathf.Clamp(
            gameSettings.resolutionIndex,
            0,
            resolutions.Length - 1
        );

        resolutionDropdown.value = gameSettings.resolutionIndex;
        resolutionDropdown.RefreshShownValue();

        // -------- APPLY SAVED SETTINGS --------
        ApplyVolume(gameSettings.masterVolume);
        QualitySettings.SetQualityLevel(gameSettings.qualityIndex);
        Screen.fullScreen = gameSettings.fullscreen;
    }

    // ---------- AUDIO ----------
    public void SetVolume(float volume)
    {
        gameSettings.masterVolume = volume;
        ApplyVolume(volume);
    }

    void ApplyVolume(float volume)
    {
        audioMixer.SetFloat("volume", Mathf.Log10(volume) * 20f);
    }

    // ---------- QUALITY ----------
    public void SetQuality(int qualityIndex)
    {
        gameSettings.qualityIndex = qualityIndex;
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    // ---------- FULLSCREEN ----------
    public void SetFullscreen(bool isFullscreen)
    {
        gameSettings.fullscreen = isFullscreen;
        Screen.fullScreen = isFullscreen;
    }

    // ---------- RESOLUTION ----------
    public void SetResolution(int resolutionIndex)
    {
        gameSettings.resolutionIndex = resolutionIndex;

        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(
            resolution.width,
            resolution.height,
            gameSettings.fullscreen
        );
    }
}

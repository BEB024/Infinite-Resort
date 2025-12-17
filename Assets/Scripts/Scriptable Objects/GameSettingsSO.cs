using UnityEngine;

[CreateAssetMenu(
    fileName = "GameSettings",
    menuName = "Infinite-Resort/Game Settings"
)]
public class GameSettingsSO : ScriptableObject
{
    [Header("Audio")]
    [Range(0f, 20f)]
    public float masterVolume = 0f;

    [Header("Display")]
    public int resolutionIndex = 0;
    public int qualityIndex = 2;
    public bool fullscreen = true;
}

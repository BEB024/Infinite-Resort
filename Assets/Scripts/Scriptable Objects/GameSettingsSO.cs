using UnityEngine;

[CreateAssetMenu(
    fileName = "GameSettings",
    menuName = "Infinite-Resort/Game Settings"
)]
public class GameSettingsSO : ScriptableObject
{
    [Header("Audio")]
    [Range(0.0001f, 1f)]
    public float masterVolume = 1f;

    [Header("Display")]
    public int resolutionIndex = 0;
    public int qualityIndex = 2;
    public bool fullscreen = true;
}

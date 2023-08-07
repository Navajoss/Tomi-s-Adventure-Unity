using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer gameVolume;
    public AudioMixer musicVolume;
    public Dropdown resolutionDropdown;
    public Dropdown qualityDropdown;
    public Slider gameVolumeSlider;
    public Slider musicVolumeSlider;

    Resolution[] resolutions;

    void Start()
    {
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " X " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();

        qualityDropdown.value = QualitySettings.GetQualityLevel();

        LoadVolumeSettings();
    }

    public void SetVolume(float volume)
    {
        gameVolume.SetFloat("GameVolume", volume);
        SaveVolumeSettings();
    }

    public void SetMusicVolume(float music)
    {
        musicVolume.SetFloat("MusicVolume", music);
        SaveVolumeSettings();
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void LoadVolumeSettings()
    {
        if (PlayerPrefs.HasKey("GameVolume"))
        {
            float gameVolumeValue = PlayerPrefs.GetFloat("GameVolume");
            gameVolume.SetFloat("GameVolume", gameVolumeValue);
            gameVolumeSlider.value = gameVolumeValue;
        }

        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            float musicVolumeValue = PlayerPrefs.GetFloat("MusicVolume");
            musicVolume.SetFloat("MusicVolume", musicVolumeValue);
            musicVolumeSlider.value = musicVolumeValue;
        }
    }

    private void SaveVolumeSettings()
    {
        PlayerPrefs.SetFloat("GameVolume", gameVolumeSlider.value);
        PlayerPrefs.SetFloat("MusicVolume", musicVolumeSlider.value);
    }
}
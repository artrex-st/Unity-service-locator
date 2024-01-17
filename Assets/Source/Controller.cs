using DataService;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    [SerializeField] private Button _loadSceneBtn;
    [SerializeField] private Button _debugBtn;
    [SerializeField] private Button _settingsBtn;
    [SerializeField] private string _sceneName;
    private string _settingsScene = "SettingsMenuPopUp";

    private ISceneService _sceneService;
    private ISaveDataService _saveDataService;

    private void Awake()
    {
        _loadSceneBtn.onClick.AddListener(LoadSceneClickHandler);
        _debugBtn.onClick.AddListener(DebugClickHandler);
        _settingsBtn.onClick.AddListener(SettingsClickHandler);

        _sceneService = ServiceLocator.Instance.GetService<ISceneService>();
        _saveDataService = ServiceLocator.Instance.GetService<ISaveDataService>();
    }

    private void SettingsClickHandler()
    {
        _sceneService.LoadingSceneAdditiveAsync(_settingsScene);
    }

    private void LoadSceneClickHandler()
    {
        _sceneService.LoadingScene(_sceneName);
    }

    private void DebugClickHandler()
    {
        _sceneService.PrintSceneName();
        Debug.Log($"MasterVolume: {_saveDataService.GameData.MasterVolume}, MusicVolume: {_saveDataService.GameData.MusicVolume}");
        _saveDataService.SaveGame();
    }
}

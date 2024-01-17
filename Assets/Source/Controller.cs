using DataService;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    [SerializeField] private Button _loadSceneBtn;
    [SerializeField] private Button _debugBtn;
    [SerializeField] private string _sceneName;

    private ISceneService _sceneService;
    private ISaveDataService _saveDataService;

    private void Awake()
    {
        _loadSceneBtn.onClick.AddListener(LoadSceneClickHandler);
        _debugBtn.onClick.AddListener(DebugClickHandler);

        _sceneService = ServiceLocator.Instance.GetService<ISceneService>();
        _saveDataService = ServiceLocator.Instance.GetService<ISaveDataService>();
        Debug.Log($"Load MasterVolume: {_saveDataService.GameData.MasterVolume}");
    }

    private void LoadSceneClickHandler()
    {
        _sceneService.LoadingScene(_sceneName);
    }

    private void DebugClickHandler()
    {
        _sceneService.PrintSceneName();
        float newFloat = UnityEngine.Random.Range(0, 100) / 100f;
        Debug.Log($"New MasterVolume: {newFloat}");
        _saveDataService.GameData.MasterVolume = newFloat;
        _saveDataService.SaveGame();
    }
}

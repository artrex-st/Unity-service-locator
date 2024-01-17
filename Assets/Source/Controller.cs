using DataService;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public readonly struct RequestStringEvent : IEvent
{
    public readonly string StringEvent;

    public RequestStringEvent(string stringEvent)
    {
        StringEvent = stringEvent;
    }
}

public class Controller : MonoBehaviour
{
    [SerializeField] private Button _loadSceneBtn;
    [SerializeField] private Button _debugBtn;
    [SerializeField] private Button _settingsBtn;
    [SerializeField] private string _sceneName;
    private const string SettingsScene = "SettingsMenuPopUp";

    private ISceneService _sceneService;
    private IEventsService _eventsService;
    private ISaveDataService _saveDataService;

    private void Awake()
    {
        _loadSceneBtn.onClick.AddListener(LoadSceneClickHandler);
        _debugBtn.onClick.AddListener(DebugClickHandler);
        _settingsBtn.onClick.AddListener(SettingsClickHandler);

        _eventsService = ServiceLocator.Instance.GetService<IEventsService>();
        _sceneService = ServiceLocator.Instance.GetService<ISceneService>();
        _saveDataService = ServiceLocator.Instance.GetService<ISaveDataService>();

        _eventsService.Subscribe<RequestStringEvent>(HandleStringEvent);
    }

    private void OnDestroy()
    {
        _eventsService.Unsubscribe<RequestStringEvent>(HandleStringEvent);
    }

    private void SettingsClickHandler()
    {
        _sceneService.LoadingSceneAdditiveAsync(SettingsScene);
    }

    private void HandleStringEvent(RequestStringEvent obj)
    {
        Debug.Log($"Event Callback from scene: {SceneManager.GetActiveScene().name}, Event Text: {obj.StringEvent}");
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

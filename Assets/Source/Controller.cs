using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    [SerializeField] private Button _loadSceneBtn;
    [SerializeField] private Button _debugBtn;
    [SerializeField] private string _sceneName;

    private ISceneService _sceneService;
    private IEventsService _eventsService;

    private void Awake()
    {
        _loadSceneBtn.onClick.AddListener(LoadSceneClickHandler);
        _debugBtn.onClick.AddListener(DebugClickHandler);

        _sceneService = ServiceLocator.Instance.GetService<ISceneService>();
        _eventsService = ServiceLocator.Instance.GetService<IEventsService>();
        _eventsService.SubscribeEvent("Debug", CallbackDebugEvent);
    }

    private void OnDestroy()
    {
        _eventsService.UnsubscribeEvent("Debug", CallbackDebugEvent);
    }

    private void CallbackDebugEvent(object obj)
    {
        Debug.Log($"Event Callback from scene: {SceneManager.GetActiveScene().name}");
    }

    private void LoadSceneClickHandler()
    {
        _sceneService.LoadingScene(_sceneName);
    }

    private void DebugClickHandler()
    {
        _sceneService.PrintSceneName();
    }
}

using DataService;
using UnityEngine;

public class ServicesSpawner : MonoBehaviour
{
    [SerializeField] private string _sceneName;
    [SerializeField] private string _saveDataName = "data.json";
    [SerializeField] private bool _useEncryption = false;

    private void Awake()
    {
        SpawnSaveDataService();
        SpawnScreenService();
    }

    private void SpawnScreenService()
    {
        GameObject screenServiceObject = new GameObject(nameof(SceneService));
        DontDestroyOnLoad(screenServiceObject);

        SceneService sceneService = new SceneService();
        ServiceLocator.Instance.RegisterService<ISceneService>(sceneService);

        sceneService.LoadingScene(_sceneName);
    }

    private void SpawnSaveDataService()
    {
        GameObject saveDataServiceObject = new GameObject(nameof(SaveDataService));
        DontDestroyOnLoad(saveDataServiceObject);
        SaveDataService saveDataService = saveDataServiceObject.AddComponent<SaveDataService>();
        ServiceLocator.Instance.RegisterService<ISaveDataService>(saveDataService);
#if !UNITY_EDITOR
        _useEncryption = true;
#endif
        saveDataService.Initialize(_saveDataName, _useEncryption);
    }
}


using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    [SerializeField] private Button _servicePlay;

    private ISceneService _sceneService;
    // Start is called before the first frame update
    private void Start()
    {
        _servicePlay.onClick.AddListener(ServicePlayClickHandler);
        _sceneService = new SceneService();
        ServiceLocator.Instance.RegisterService<ISceneService>(_sceneService);
    }

    private void ServicePlayClickHandler()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}

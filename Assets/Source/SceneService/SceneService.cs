using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneService : MonoBehaviour, ISceneService
{
    private Scene _additiveScenes;
    public void LoadingScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void LoadingSceneAdditiveAsync(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        Scene loadedScene = SceneManager.GetSceneAt(SceneManager.sceneCount - 1);

        _additiveScenes = loadedScene;
    }

    public void UnLoadAdditiveSceneAsync()
    {
        SceneManager.UnloadSceneAsync(_additiveScenes);
    }

    public void PrintSceneName()
    {
        Debug.Log($"This active scene Name is: {SceneManager.GetActiveScene().name}");
    }
}

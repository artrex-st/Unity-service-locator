using Source;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISceneService
{
    public void LoadingScene(ScreenReference sceneName);
    public void LoadingSceneAdditiveAsync(ScreenReference sceneName);
    public void UnLoadAdditiveSceneAsync();
    public void PrintSceneName();
}

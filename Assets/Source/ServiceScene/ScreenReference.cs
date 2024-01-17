using UnityEngine;

namespace Source
{
    [CreateAssetMenu(menuName = "Services/Screen Reference")]
    public sealed class ScreenReference : ScriptableObject
    {
        [SerializeField] private string _sceneName;

        public string SceneName => _sceneName;
    }
}

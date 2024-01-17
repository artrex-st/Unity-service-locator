using UnityEngine;

[CreateAssetMenu(fileName = ("New SoundLibrary"), menuName = ("Sound/Library"))]
public class SoundLibrary : ScriptableObject
{
    //[FoldoutGroup("Musics")]
    public AudioClip MainMenuMusic;
    //[FoldoutGroup("UiEfx")]
    public AudioClip UiClick;
}


using UnityEngine;

[System.SerializableAttribute]
public class SoundData
{
    public AudioClip audioClip;
    [SerializeField] private float startAfter;

    public float StartAfter => startAfter;
}

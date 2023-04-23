using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private List<SoundData> soundDataList;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        foreach (SoundData soundData in soundDataList)
        {
            StartCoroutine(PlaySoundAfterDelay(soundData.audioClip, soundData.StartAfter));
        }
    }

    private IEnumerator PlaySoundAfterDelay(AudioClip audioClip, float delay)
    {
        yield return new WaitForSeconds(delay);
        PlaySound(audioClip);
    }

    private void PlaySound(AudioClip audioClip)
    {
        if (audioSource != null && audioClip != null)
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}

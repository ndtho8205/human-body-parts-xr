using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxAudioController : MonoBehaviour
{
    [SerializeField]
    AudioSource _sfxAudioSource;

    [SerializeField]
    AudioClip _fingerTapSfx;

    public void OnFingerTap()
    {
        _sfxAudioSource.PlayOneShot(_fingerTapSfx, 1.0f);
    }
}

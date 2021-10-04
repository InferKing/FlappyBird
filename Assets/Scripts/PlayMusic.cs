using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    [SerializeField] private AudioClip[] _audio;
    private AudioSource _audioSource;
    private AudioClip _aud;
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _aud = _audio[(int)Random.Range(0, 3)];
        _audioSource.PlayOneShot(_aud);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0) _audioSource.Stop();
        else if (Time.timeScale == 1 && !_audioSource.isPlaying) _audioSource.PlayOneShot(_aud);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerOfPlayer : MonoBehaviour
{
    [SerializeField] private float _powerOfTap = 5f;
    [SerializeField] private GameObject _restartButton;
    [SerializeField] private bool _isCheatMode = false;
    private Rigidbody2D _rb;
    private AudioSource _audio;
    private bool _isPressed = false;
    private bool _isDied = false;

    private void Start()
    {
        Time.timeScale = 1;
        _rb = GetComponent<Rigidbody2D>();
        _audio = GetComponent<AudioSource>();
        _isDied = false;
}
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!_audio.isPlaying && Time.timeScale != 0) _audio.Play();
            _isPressed = true;
            Debug.Log(_rb.velocity);
        }
    }
    private void FixedUpdate()
    {
        if (_isPressed)
        {
            _rb.velocity = new Vector2(0f, _powerOfTap * Time.fixedDeltaTime * 50f);
            _isPressed = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy" && !_isCheatMode)
        {
            Time.timeScale = 0;
            _restartButton.SetActive(true);
        }
    }
}

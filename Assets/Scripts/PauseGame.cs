using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private GameObject _restartButton;

    public void Pause()
    {
        if (!_restartButton.activeInHierarchy)
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                _rb.velocity = new Vector2(0, 0);
            }
        }
        
    }


}

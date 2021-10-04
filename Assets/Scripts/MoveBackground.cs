using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField] private float _speedX = 3f;

    private void FixedUpdate()
    {
        transform.Translate(-_speedX * Time.fixedDeltaTime, 0, 0);
    }
}

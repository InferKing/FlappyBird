using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject gobj;
    [SerializeField] private bool _isRand = false;
    [SerializeField] private float _waitingTime = 3f;
    [SerializeField] private float _distanceFromPlayer = 15f;
    private float _rand = 0f;

    private void Start()
    {
        StartCoroutine(Spawner());
    }
    IEnumerator Spawner()
    { 
        while (true)
        {
            yield return new WaitForSeconds(_waitingTime);
            if (_isRand) _rand = Random.Range(-3f, 1f);
            GameObject newObj = Instantiate(gobj,new Vector2(_distanceFromPlayer,_rand),Quaternion.identity);
            Destroy(newObj, 15);
        }
    }

}

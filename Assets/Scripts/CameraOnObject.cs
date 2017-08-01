using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOnObject : MonoBehaviour
{

    [SerializeField] private GameObject _gameObject;
    [SerializeField] private GameObject _camera;


    private void Update()
    {
        _camera.transform.position = _gameObject.transform.position;
    }
}

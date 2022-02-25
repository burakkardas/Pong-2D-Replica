using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    [SerializeField] private Transform _ballTransform = null;
    [SerializeField] private float _lerpTime = 0;
    void Update()
    {
        float _newX = _ballTransform.position.x;

        _newX = Mathf.Clamp(_newX, -1.95f, 1.95f);

        _newX = Mathf.Lerp(transform.position.x, _newX, _lerpTime * Time.deltaTime);

        transform.position = new Vector3(
            _newX,
            transform.position.y,
            transform.position.z
        );
    }
}

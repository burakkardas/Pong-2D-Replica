using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private Rigidbody2D _rigidBody = null;
    [SerializeField] private float _moveSpeed = 5f;
    Vector3 _lastVelociy;
    void Start()
    {
        Respawn();
    }

    private void Update() {
        _lastVelociy = _rigidBody.velocity;
        CheckScore();
    }

    public void Respawn() {
        transform.position = Vector3.zero;
        _rigidBody.velocity = Random.insideUnitCircle.normalized * _moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        var _speed = _lastVelociy.magnitude;
        var _dir = Vector3.Reflect(_lastVelociy.normalized, other.contacts[0].normal);
        _rigidBody.velocity = _dir * Mathf.Max(_speed, 0f);
    }


    private void CheckScore() {
        if(transform.position.y >= 5.2f) {
            _gameManager.SetPlayerScore(1);
            Respawn();
        }
        else if(transform.position.y <= -5.2f) {
            _gameManager.SetEnemyScore(1);
            Respawn();
        }
    }
}

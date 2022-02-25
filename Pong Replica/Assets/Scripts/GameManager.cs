using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _playerScoreText = null;
    [SerializeField] private TMP_Text _enemyScoreText = null;
    private int _playerScore = 0;
    private int _enemyScore = 0;

    public int GetPlayScore() {
        return _playerScore;
    }
    public void SetPlayerScore(int _value) {
        _playerScore += _value;
    }

    public int GetEnemyScore() {
        return _enemyScore;
    }

    public void SetEnemyScore(int _value) {
        _enemyScore += _value;
    }

    private void Update() {
        _playerScoreText.text = _playerScore.ToString("00");
        _enemyScoreText.text = _enemyScore.ToString("00");
    }

}

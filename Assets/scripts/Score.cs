using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _score;


    private void OnEnable()
    {
        _player.ScoreChange += OnScoreeChanged;
    }

    
    private void OnDisable()
    {
        _player.ScoreChange -= OnScoreeChanged;
    }

    private void OnScoreeChanged(int value)
    {
        _score.text = value.ToString();
    }

}

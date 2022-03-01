using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private MenuController _menuController;
    [SerializeField] private TMP_Text _winOrLoseText;
    [SerializeField] private TMP_Text _timePanel;


    public event UnityAction<int> ScoreChange;
    public float _time = 0;

    private void Start()
    {
        ScoreChange?.Invoke(_score);
    }

    private void Update()
    {
        _time += Time.deltaTime;
        _timePanel.text = _time.ToString("0.0");
    }
    public void ApplyScoree(int value)
    {     
        _score += value;
        ScoreChange?.Invoke(_score);
        if (_score>=5)
        {          
            GameFinish();
        }
    }
    public void GameFinish()
    {       
        _menuController.RestartMenuPanel();
        if (_time <= 3f)
        {
            _winOrLoseText.text = "WIN";
        }
        else
        {
            _winOrLoseText.text = "Lose";
        }
    }
}

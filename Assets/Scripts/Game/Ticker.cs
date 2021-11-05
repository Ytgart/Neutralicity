using System;
using UnityEngine;

public class Ticker : MonoBehaviour
{
    private float _tickRate = 1;
    public Action OnTicked;
    private float _tickCounter = 0;
    private int _currentTick;
    private bool _isPaused = false;

    private void Update()
    {
        Tick();
    }

    private void Tick()
    {
        if (!_isPaused)
        {
            _tickCounter += Time.deltaTime;
            if (_tickCounter >= _tickRate)
            {
                _currentTick++;
                _tickCounter = 0;
                OnTicked();
            }
        }
    }

    public string GetCurrentDate()
    {
        return $"Year: {_currentTick / 365}, Day: {_currentTick}";
    }

    public void TogglePausedState()
    {
        if (_isPaused)
        {
            _isPaused = false;
        }
        else _isPaused = true;
    }

    public float ChangeSpeed(float speedDelta)
    {
        _tickRate += speedDelta;
        _tickRate = Mathf.Clamp(_tickRate, 0.1f, 1);
        return _tickRate;
    }
}

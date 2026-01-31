using System;
using UnityEngine;

public class TimeManager
{
    public event Action OnTimeEnd;
    public event Action<float> OnTimeUpdate;

    private float _timeLimit;
    private float _currentTime;
    private bool _isRunning;

    public TimeManager(float time)
    {
        _timeLimit = time;
        _currentTime = _timeLimit;
    }

    public void Start()
    {
        _isRunning = true;
    }

    public void Stop()
    {
        _isRunning = false;
    }


    public void Tick(float deltaTime)
    {
        if (!_isRunning) { return; }

        _currentTime = Mathf.Max(0, _currentTime - deltaTime);
        OnTimeUpdate?.Invoke(_currentTime);

        if (_currentTime <= 0)
        {
            TimeEnd();
        }
    }


    private void TimeEnd()
    {
        _isRunning = false;
        OnTimeEnd?.Invoke();
    }
}

using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float _timeLimit = 200;

    private GameState _state;
    private TimeManager _timeManager;

    private void Start()
    {
        _timeManager = new TimeManager(_timeLimit);

        _timeManager.OnTimeEnd += OnTimeUp;

        StartGame();
    }

    private void Update()
    {
        _timeManager.Tick(Time.deltaTime);
    }

    private void StartGame()
    {
        _state = GameState.Playing;
        _timeManager.Start();
    }

    private void OnTimeUp()
    {
        FinishGame();
    }

    private void FinishGame()
    {
        _state = GameState.Finished;
        Debug.Log("Game End");
    }
}

public enum GameState
{
    [InspectorName("準備中")]
    Ready,
    [InspectorName("インゲーム")]
    Playing,
    [InspectorName("ゲーム終了")]
    Finished,
    [InspectorName("演出など再生中")]
    Effect,
}

using UnityEngine;
using UnityEngine.UI;

public class TimePanel : MonoBehaviour
{
    [SerializeField] private Ticker _ticker;
    [SerializeField] private Button _pauseButton;
    [SerializeField] private Button _fasterButton;
    [SerializeField] private Button _slowerButton;
    [SerializeField] private Text _dateText;
    [SerializeField] private Text _speedText;

    private void Awake()
    {
        _ticker.OnTicked += UpdateDate;
        _pauseButton.onClick.AddListener(() =>
        {
            _ticker.TogglePausedState();
        });
        _fasterButton.onClick.AddListener(() =>
        {
            _speedText.text = $"Speed: {_ticker.ChangeSpeed(-0.1f)} сек.";
        });
        _slowerButton.onClick.AddListener(() =>
        {
            _speedText.text = $"Speed: {_ticker.ChangeSpeed(0.1f)} сек.";
        });
    }

    private void UpdateDate()
    {
        _dateText.text = _ticker.GetCurrentDate();
    }
}

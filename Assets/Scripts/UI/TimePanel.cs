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
        _speedText.text = $"Speed: 1 sec.";
        _ticker.OnTicked += UpdateDate;
        _pauseButton.onClick.AddListener(() =>
        {
            _ticker.TogglePausedState();
        });
        _fasterButton.onClick.AddListener(() =>
        {
            _speedText.text = $"Speed: {_ticker.ChangeSpeed(-0.1f)} sec.";
        });
        _slowerButton.onClick.AddListener(() =>
        {
            _speedText.text = $"Speed: {_ticker.ChangeSpeed(0.1f)} sec.";
        });
    }

    private void UpdateDate()
    {
        _dateText.text = _ticker.GetCurrentDate();
    }
}

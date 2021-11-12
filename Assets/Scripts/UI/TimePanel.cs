using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class TimePanel : Panel
{
    [Inject] private Ticker _ticker;

    private void Awake()
    {
        _texts[0].text = $"Speed: 1 sec.";
        _ticker.OnTicked += UpdateDate;
        _buttons[0].onClick.AddListener(() =>
        {
            _ticker.TogglePausedState();
        });
        _buttons[1].onClick.AddListener(() =>
        {
            _texts[0].text = $"Speed: {_ticker.ChangeSpeed(-0.1f)} sec.";
        });
        _buttons[2].onClick.AddListener(() =>
        {
            _texts[0].text = $"Speed: {_ticker.ChangeSpeed(0.1f)} sec.";
        });
    }

    private void UpdateDate()
    {
        _texts[1].text = _ticker.GetCurrentDate();
    }
}

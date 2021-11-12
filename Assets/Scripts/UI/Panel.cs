using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public abstract class Panel : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] protected List<Button> _buttons = new List<Button>();
    [SerializeField] protected List<Text> _texts = new List<Text>();

    public void SetVisible(bool state)
    {
        GetComponent<Image>().color = new Color32(255, 255, 255, (byte)(Convert.ToInt32(state) * 255));

        foreach (var item in _buttons)
        {
            item.gameObject.SetActive(state);
        }

        foreach (var item in _texts)
        {
            item.gameObject.SetActive(state);
        }
    }
}

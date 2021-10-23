using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TilePanel : MonoBehaviour
{
    [SerializeField] private Text _data;

    public void ShowTileInfo(PathData data)
    {
        if (!(data is null))
        {
            if (data.PreviousTile != null)
            {
                _data.text = $@"
                Координаты: x = {data.Position.x}, y = {data.Position.y}
                Тип: {data.Type.ToString()}
                F = {data.F}
                G = {data.G}
                H = {data.H}
                Модификатор: {((int)data.Type)}
                Предыдущий тайл: {data.PreviousTile.Position.x}   {data.PreviousTile.Position.y}"; 
            }
        }
    }
}

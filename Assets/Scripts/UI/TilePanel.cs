using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TilePanel : MonoBehaviour
{
    [SerializeField] private Text _data;

    public void ShowTileInfo(PathData data, Vector3Int tilePosition)
    {
        if (!(data is null))
        {
            _data.text = $@"
            Координаты: x = {tilePosition.x}, y = {tilePosition.y}
            Тип: {data.Type.ToString()}
            F = {data.F}
            G = {data.G}
            H = {data.H}
            Модификатор: {((int)data.Type)}";
        }
    }
}

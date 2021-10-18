using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUnit : MonoBehaviour
{
    private float _speed;

    public void MoveToPosition(Vector3 newPosition)
    {
        transform.position = newPosition;
    }
}

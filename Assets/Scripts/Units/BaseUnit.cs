using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUnit : MonoBehaviour, IDamageable
{
    protected List<Vector2> _path;
    protected int _index = 0;
    protected float _speed;
    protected int _damage;
    public int HealthPoints { get; set; }

    public BaseUnit(List<Vector2> path)
    {
        _path = path;
        transform.position = path[_index++];
    }

    protected void FindNextDestination()
    {
        MoveToPosition(_path[_index++]);
    }
    protected void MoveToPosition(Vector2 newPosition)
    {
        transform.position = newPosition;
    }

    public void TakeDamage(int damageAmount)
    {
        HealthPoints -= damageAmount;
    }
}

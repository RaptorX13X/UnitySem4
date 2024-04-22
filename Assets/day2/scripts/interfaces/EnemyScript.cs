using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour, IDamagable
{
    private int _currentHp = 1;

    int IDamagable.currentHP
    {
        get => _currentHp;
        set => _currentHp = value;
    }

    public void TakeDamage(int dmg)
    {
        _currentHp -= dmg * 2;
        if (_currentHp <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}

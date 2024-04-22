using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour, IDamagable
{
    private int _currentHp = 10;

    int IDamagable.currentHP
    {
        get => _currentHp;
        set => _currentHp = value;
    }

    public void TakeDamage(int dmg)
    {
        _currentHp -= dmg;
        if (_currentHp <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
        GameManager.Instance.LoadMainMenu();
    }
}

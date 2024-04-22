using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable
{
    int currentHP { get; protected set; }
    
    public void TakeDamage(int dmg);

    public void Die();
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    
    void Update()
    {
        transform.position += Vector3.right * (Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MonoBehaviour>() is IDamagable damagable)
        {
            damagable.TakeDamage(1);
            Debug.Log(damagable.currentHP);
        }
    }
}

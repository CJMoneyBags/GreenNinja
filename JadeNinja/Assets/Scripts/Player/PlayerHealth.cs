using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamagable
{
    [Header("Config")]
    [SerializeField] private PlayerStats stats;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TakeDamage(1f);
        }
    }

    public void TakeDamage(float amount)
    {

        stats.Health -= amount;
        if (stats.Health <= 0)
        {
            PlayerDead();
        }
    }

    private void PlayerDead()
    {
        Debug.Log("Dead");
    }
}

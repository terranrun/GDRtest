using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _bonus;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.ApplyScoree(_bonus);
        }
        Die();
    }
    private void Die()
    {
        gameObject.SetActive(false);
    }
}

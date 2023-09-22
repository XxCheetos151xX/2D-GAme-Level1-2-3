using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private int Enemy_health;
    void Start()
    {
        Enemy_health = 30;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Enemy_health = Enemy_health - 10;
        }
        if (Enemy_health == 0)
        {
            gameObject.SetActive(false);
        }
    }

}

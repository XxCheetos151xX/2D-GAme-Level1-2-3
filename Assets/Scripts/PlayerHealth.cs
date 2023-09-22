using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private int health_player;
    [SerializeField] private GameObject failpanel;
    void Start()
    {
        health_player = 30;
    }
   
private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            health_player = health_player - 10;
        }
        if (health_player == 0)
        {
            gameObject.SetActive(false);
            failpanel.SetActive(true);

        }

    }
  
} 

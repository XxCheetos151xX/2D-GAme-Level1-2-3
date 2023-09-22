using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
    [SerializeField]private Rigidbody2D bullet_rb;
    [SerializeField] private float bullet_speed;
    void Start()
    {
       
        bullet_rb.velocity = new Vector2(bullet_speed, bullet_rb.velocity.y);
        Destroy(gameObject, 4);
        
    }



}

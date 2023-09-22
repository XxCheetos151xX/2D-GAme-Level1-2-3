using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Transform shooting_pos;
    [SerializeField] private GameObject bulletprefab;
   
    public void Shoot()
    {
        Instantiate(bulletprefab, shooting_pos.position, transform.rotation);
    }
}

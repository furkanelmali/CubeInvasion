using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;
    public void GetDamage(int _damage)
    {
        FindObjectOfType<AudioManager>().Play("Hit");
        Debug.Log("Damage Taken");
        health -= _damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  Code for TARGETS only!
 * 
 * Remember!
 * 
 * 9/2/18
 * 
 * */

public class Target : MonoBehaviour
{

    public float health = 50f;

    public void TakeDamage(float amount)
    {
        
        health -= amount;
        if (health <= 0f)
        {
           Die();
        }
    }

    void Die()
    {
        gameObject.SetActive(false);

    }

}
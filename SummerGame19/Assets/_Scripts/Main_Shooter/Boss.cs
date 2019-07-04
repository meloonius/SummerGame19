using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int health = 100;

    //public Animation deathEffect;
    public GameObject winMenuUi;

    public void TakeDamage(int damage)
    {
        health -= damage;
        
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //deathEffect
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        //deathEffect.Play("die");
        //Time.timeScale = 0f;
        winMenuUi.gameObject.SetActive(true);
    }
}

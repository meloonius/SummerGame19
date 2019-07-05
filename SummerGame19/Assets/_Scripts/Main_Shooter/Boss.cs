using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int health = 100;
    public Animator anim;

    public GameObject winMenuUi;

    private void Update()
    {
        if (health <= 0)
        {
            anim = GetComponent<Animator>();
            anim.Play("Boss1Death");
            StartCoroutine(WaitBossDeath());
        }

    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    IEnumerator WaitBossDeath()
    {
        yield return new WaitForSeconds(1.6f);
        winMenuUi.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float speed;

    Rigidbody2D rigBody;
    Vector2 moveVelocity;

    public Transform firePoint;
    public GameObject bulletPrefab;


    void Start()
    {
        rigBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }


    private void FixedUpdate()
    {
        rigBody.MovePosition(rigBody.position + moveVelocity * Time.fixedDeltaTime);
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}

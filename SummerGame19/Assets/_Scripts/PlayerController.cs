using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float speed;

    Rigidbody2D rigBody;
    Vector2 moveVelocity;
    Collider2D boxCol;
    void Start()
    {
        rigBody = GetComponent<Rigidbody2D>();
        boxCol = GetComponent<Collider2D>();
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }


    private void FixedUpdate()
    {
        rigBody.MovePosition(rigBody.position + moveVelocity * Time.fixedDeltaTime);
    }
}

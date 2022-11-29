using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1and2Movement : MonoBehaviour
{
    public float movementSpeed = 5;
    public Rigidbody2D rb;

    //Keycode for 2 different player
    public KeyCode left;
    public KeyCode right;

    public KeyCode up;
    public KeyCode down;

    public ParticleSystem dust;

    private void OnEnable()
    {
        HealthImpact.onPlayerDeath += DisableOnAction;
    }
    private void OnDisable()
    {
        HealthImpact.onPlayerDeath -= DisableOnAction;
    }

    private void Start()
    {
        EnableOnAction();
    }
    private void FixedUpdate() //Execute per second
    {
        //Movement
        if (Input.GetKey(left))
        {
            transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
            transform.localScale = new Vector2(-1, 1);
            dust.Play();
        }

        if (Input.GetKey(down))
        {
            transform.Translate(Vector2.down * movementSpeed * Time.deltaTime);
            dust.Play();
        }

        if (Input.GetKey(right))
        {
            transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
            transform.localScale = new Vector2(1, 1);
            dust.Play();
        }

        if (Input.GetKey(up))
        {
            transform.Translate(Vector2.up * movementSpeed * Time.deltaTime);
            dust.Play();
        }
    }

    private void DisableOnAction()
    {
        rb.bodyType = RigidbodyType2D.Static;
    }

    private void EnableOnAction()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
    }
}

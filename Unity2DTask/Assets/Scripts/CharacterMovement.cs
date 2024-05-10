using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMovement : MonoBehaviour
{
    private CharacterController controller;
    private Rigidbody2D rigidbody;
    Vector2 dir;
    [SerializeField] float speed;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    public void Move(Vector2 dir)
    {
        this.dir = dir;
    }

    private void FixedUpdate()
    {
        Movement();   
    }

    private void Movement()
    {
        rigidbody.velocity = dir * speed;
    }
}

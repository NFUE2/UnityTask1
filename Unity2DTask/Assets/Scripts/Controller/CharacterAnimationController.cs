using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;
    private static readonly int isWalking = Animator.StringToHash("Walking");
    private CharacterController controller;
    private readonly float magnitude = 0.5f;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 dir)
    {
        animator.SetBool(isWalking, dir.magnitude > magnitude);
    }

}

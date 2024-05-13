using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;
    private static readonly int isWalking = Animator.StringToHash("Walking");
    private CharacterController controller;
    private SpriteRenderer renderer;
    private readonly float magnitude = 0.5f;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
        renderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 dir)
    {
        animator.SetBool(isWalking, dir.magnitude > magnitude);
    }

    public void ChangeACharacter(PlayerObject player)
    {
        animator.runtimeAnimatorController = player.contorller;
        renderer.sprite = player.CharacterIdle;
    }
}

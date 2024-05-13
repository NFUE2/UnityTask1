using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAim : MonoBehaviour
{
    private CharacterController controller;
    private SpriteRenderer renderer;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        renderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 dir) 
    {
        RotateCharacter(dir);
    }

    private void RotateCharacter(Vector2 dir)
    {
        float rotZ = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        renderer.flipX = Mathf.Abs(rotZ) > 90f;
    }

    public void ChangeRenderer(SpriteRenderer renderer)
    {
        this.renderer = renderer;
    }
}

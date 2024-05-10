using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : CharacterController
{
    public void OnMove(InputValue value)
    {
        Vector2 dir = value.Get<Vector2>().normalized;
        CallMoveEvent(dir);
    }

    public void OnLook(InputValue value)
    {
        Vector2 aim = value.Get<Vector2>();
        Vector2 dir = Camera.main.ScreenToWorldPoint(aim);

        aim = (dir - (Vector2)transform.position).normalized;

        CallLookEvent(aim);
    }
}

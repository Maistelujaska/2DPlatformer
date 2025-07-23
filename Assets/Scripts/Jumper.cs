using UnityEngine;
using UnityEngine.InputSystem;
public class Jumper : MonoBehaviour
{
    public Rigidbody2D rb;
    [Header("Jumping")]
    public float jumpPower = 10f;
    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);
        }
    }
}

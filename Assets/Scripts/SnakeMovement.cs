using UnityEngine;
using UnityEngine.InputSystem;

public class SnakeMovement : MonoBehaviour
{
    private PlayerInput playerInput;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    private void OnEnable()
    {
        playerInput.actions.FindAction("Move").performed += OnMove;
    }

    void OnDisable()
    {
        playerInput.actions.FindAction("Move").performed -= OnMove;
    }

    // Este método se debe conectar al evento 'Performed' de tu InputAction
    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();

        // Evitar desplazamientos en diagonal si se pulsan dos teclas casi a la vez
        Vector3 step = Vector3.zero;

        if (Mathf.Abs(input.x) > Mathf.Abs(input.y))
        {
            step.x = Mathf.Sign(input.x); // +1 a la derecha, -1 a la izquierda
        }
        else if (Mathf.Abs(input.y) > 0f)
        {
            step.y = Mathf.Sign(input.y); // +1 arriba, -1 abajo
        }

        // Mover exactamente 1 unidad
        transform.position += step;
    }
}

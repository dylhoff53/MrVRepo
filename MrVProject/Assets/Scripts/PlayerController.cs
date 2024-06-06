using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Vector2 playerInput;

    public enum state
    {
        idle,
        moving,
    }


    public void UpdateInput(InputAction.CallbackContext context)
    {
        playerInput = context.ReadValue<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 PlayerInputs = new Vector2(playerInput.x, playerInput.y);
        float xAxis = 0f;
        float zAxis = 0f;

    }
}

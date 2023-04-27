using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigidBody;
    private PlayerInput playerInputAction;

    private void Awake()
    {
        playerInputAction = new PlayerInput();
        playerInputAction.Enable();
        rigidBody = GetComponent<Rigidbody>();
    }

    public void Jump(InputAction.CallbackContext context)
    {
        Debug.Log("The jump button is pressed!");
        //if (context.performed)
        //{
            //Debug.Log("The jump button is pressed!");
        //}
    }
}

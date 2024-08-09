using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementManager : MonoBehaviour
{
   
    public VariableJoystick joystick;
    public Rigidbody2D rb;
    public float movementSpeed;

    public Canvas inputCanvas;
    public bool isJoystick;

    private void Start()
    {
        EnableJoystickInput();
    }

    public void EnableJoystickInput()
    {
        isJoystick = true;
        inputCanvas.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (isJoystick)
        {
            var movementDirection = new Vector2(joystick.Direction.x, joystick.Direction.y);
            rb.velocity = movementDirection * movementSpeed;
        }
    }



}

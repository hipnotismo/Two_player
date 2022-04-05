using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private float speed = 6;
    [SerializeField] private float jumpSpeed = 3.5f;
    [SerializeField] private float gravity = 9.5f;
    private float directionY;
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(vertical, 0f, -horizontal).normalized;


        if (controller.isGrounded)
        {
            if (Input.GetButton("Jump"))
            {
                directionY = jumpSpeed;
            }
        }
      
        directionY -= gravity * Time.deltaTime;
        direction.y = directionY;
        if (direction.magnitude >= 0.1f) 
        {
            controller.Move(direction * speed * Time.deltaTime);
        }

    }
}

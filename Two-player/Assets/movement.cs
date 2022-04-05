using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private float speed = 6;
    [SerializeField] private float jumpSpeed;

     void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(vertical, 0f, -horizontal).normalized;

        if (direction.magnitude >= 0.1f) 
        {
            controller.Move(direction * speed * Time.deltaTime);
        }

    }
}

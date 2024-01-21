using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
   public float horizontalInput;
   public float verticalInput;
   public float speed;
   Vector3 moveDirection;
   Rigidbody rb;
   public Transform orientation;

   private void Start()
   {
       rb = GetComponent<Rigidbody>();
       rb.freezeRotation = true;
   }
    // Update is called once per frame
    private void Update()
    {
       MyInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
    

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}

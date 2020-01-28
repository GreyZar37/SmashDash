using UnityEngine;
using System.Collections;



public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 6.0f;
    public float gravity = 20.0f;

    public Rigidbody rb;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal")*speed*Time.deltaTime, rb.velocity.y, Input.GetAxis("Vertical")*speed*Time.deltaTime);
        
        

        rb.velocity = moveDirection;
        

    }
}
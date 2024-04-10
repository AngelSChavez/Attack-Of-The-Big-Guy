using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class NormalGuyController : MonoBehaviour
{
    PlayerInput playerInput;
    InputAction moveAction;
    public Rigidbody rb;
    public Collider cd;
    public Transform orientation;
    float distanceToTheGround;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cd = GetComponent<Collider>();

        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //MovePlayer();
        //SpeedControl();

        if (CheckGround()) //if on the ground, add ground drag (otherwise it plays like an ice level in mario)
        {
            MovePlayer();
            SpeedControl();
            rb.drag = 6;
        }
        else //if in the air, have less drag (air resistance)
        {
            MovePlayerAir();
            SpeedControl();
            rb.drag = 0;
        }

    }

    private void OnJump()
    {
        if (CheckGround())
        {
            rb.AddForce(Vector2.up * 7, ForceMode.Impulse);
        }

    }

    private void MovePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();

        Vector3 moveDirection = orientation.forward * direction.y + orientation.right * direction.x;

        //rb.velocity = moveDirection * moveSpeed;
        
        rb.AddForce(moveDirection * moveSpeed, ForceMode.VelocityChange);

    }

    private void MovePlayerAir()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();

        Vector3 moveDirection = orientation.forward * direction.y + orientation.right * direction.x;

        rb.AddForce(moveDirection * moveSpeed, ForceMode.VelocityChange);

    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if (flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
        
    }

    public bool CheckGround()
    {
        distanceToTheGround = cd.bounds.extents.y;
        return Physics.Raycast(transform.position, Vector3.down, distanceToTheGround + 0.1f);
    }

}
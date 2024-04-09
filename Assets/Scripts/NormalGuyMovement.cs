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
    public float distanceToTheGround;
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
        MovePlayer();
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

        rb.AddForce(moveDirection * moveSpeed);


    }

    public bool CheckGround()
    {
        distanceToTheGround = cd.bounds.extents.y;
        return Physics.Raycast(transform.position, Vector3.down, distanceToTheGround + 0.1f);
    }


}
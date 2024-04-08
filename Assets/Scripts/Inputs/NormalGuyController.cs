using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class NormalGuyController : MonoBehaviour
{
    PlayerInput playerInput;
    InputAction moveAction;
    private Rigidbody rb;
    private Collider cd;
    private float distanceToTheGround;

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
        rb.AddForce(direction.x, 0, direction.y);
        
        
    }

    public bool CheckGround()
    {
        distanceToTheGround = cd.bounds.extents.y;
        return Physics.Raycast(transform.position, Vector3.down, distanceToTheGround + 0.1f);
    }


}

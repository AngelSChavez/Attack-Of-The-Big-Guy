using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NormalPlayerController : MonoBehaviour
{

    public Transform playerCamera; //Object by which the camera is controlled
    public Transform playerModel; //Object by which the player model is moved by the camera 

    public float lookSensitivity; // mouse sensitivity
    float xRotation; //camera x-axis rotation
    float yRotation; //camera y-axis rotation

    PlayerInput playerInput; //Input System for Player
    InputAction moveAction; //Stores movement values from input system
    public Rigidbody rb;

    public Collider cd;
    float distanceToTheGround;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        rb = GetComponent<Rigidbody>();
        cd = GetComponent<Collider>();

        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");

    }

    // Update is called once per frame
    void Update()
    {
        mouseLook();
    }

    private void FixedUpdate()
    {
        playerRotate();

        if (CheckGround()) //if on the ground, add ground drag (otherwise it plays like an ice level in mario)
        {
            MovePlayer();
            rb.drag = 6;
        }
        else //if in the air, have no drag (affects gravity)
        {
            MovePlayerAir();
            rb.drag = 0; //Air resistance calculated in MovePlayerAir method (to avoid affecting gravity)
        }

    }

    void mouseLook() //Moves camera
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.fixedDeltaTime * lookSensitivity;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.fixedDeltaTime * lookSensitivity;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        playerCamera.rotation = Quaternion.Euler(xRotation, yRotation, 0);

    }

    void playerRotate() //Moves player model to face camera direction
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.fixedDeltaTime * lookSensitivity;
        yRotation += mouseX;

        playerModel.rotation = Quaternion.Euler(0, yRotation, 0);

    }

    private void MovePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();

        Vector3 moveDirection = playerModel.forward * direction.y + playerModel.right * direction.x;

        rb.AddForce(moveDirection * 75, ForceMode.Force);

    }

    private void MovePlayerAir()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();

        Vector3 moveDirection = playerModel.forward * direction.y + playerModel.right * direction.x;

        rb.AddForce(moveDirection / 4, ForceMode.VelocityChange);

        Vector3 airDrag = new Vector3(-rb.velocity.x, 0f, -rb.velocity.z);
        rb.AddForce(airDrag * 1, ForceMode.Acceleration);

    }

    private void OnJump() //Jumps if you're on the ground
    {
        if (CheckGround())
        {
            rb.AddForce(Vector2.up * 7, ForceMode.Impulse);
        }

    }

    public bool CheckGround()
    {
        distanceToTheGround = cd.bounds.extents.y;
        return Physics.Raycast(transform.position, Vector3.down, distanceToTheGround + 0.1f);
    }

}

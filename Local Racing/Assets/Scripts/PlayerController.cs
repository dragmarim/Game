using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
 
    public float playerSpeed;
    public float sprintSpeed = 4f;
    public float walkSpeed = 2f;
    public float mouseSensitivity = 2f;
    public float baseMouseSensitivity = 2f;
    public float jumpHeight = 3f;
    private bool isMoving = false;
    private bool isSprinting = false;
    private float yRot;
    public float baseDrag;
    public float newDrag;
    public float maxSpeed;
 
    private Rigidbody rigidBody;
 
    void Start () {
 
        playerSpeed = walkSpeed;
        rigidBody = GetComponent<Rigidbody>();
        baseMouseSensitivity = mouseSensitivity;
        baseDrag = rigidBody.drag;
 
    }
 
    void Update () {
 
        yRot += Input.GetAxisRaw("LeftJoystickX") * mouseSensitivity;
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, yRot, transform.localEulerAngles.z);
 
        isMoving = false;
        Debug.Log(Input.GetAxisRaw("LeftTrigger"));
        if(Input.GetKey(KeyCode.JoystickButton0) && Input.GetAxisRaw("RightTrigger") > 0.5f && Input.GetAxisRaw("LeftJoystickX") > 0.5f) {
            mouseSensitivity = baseMouseSensitivity * 1.5f;
            rigidBody.drag = newDrag;
        }
        else if (Input.GetKey(KeyCode.JoystickButton0) && Input.GetAxisRaw("LeftTrigger") < -0.5f && Input.GetAxisRaw("LeftJoystickX") < -0.5f) {
            mouseSensitivity = baseMouseSensitivity * 1.5f;
            rigidBody.drag = newDrag;
        }
        else if (!Input.GetKey(KeyCode.JoystickButton1)) {
            mouseSensitivity = baseMouseSensitivity;
            rigidBody.drag = baseDrag;
        }
        else {
            rigidBody.drag = newDrag;
        }
 
        if (Input.GetKey(KeyCode.JoystickButton0) && !Input.GetKey(KeyCode.JoystickButton1) && rigidBody.velocity.magnitude <= maxSpeed)
        {
            //transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * playerSpeed);
            rigidBody.velocity += transform.forward * playerSpeed;
            isMoving = true;
        }
 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * jumpHeight);
        }
 
        if (Input.GetAxisRaw("Sprint") > 0f)
        {
            playerSpeed = sprintSpeed;
            isSprinting = true;
        }else if (Input.GetAxisRaw("Sprint") < 1f)
        {
            playerSpeed = walkSpeed;
            isSprinting = false;
        }
 
    }
}
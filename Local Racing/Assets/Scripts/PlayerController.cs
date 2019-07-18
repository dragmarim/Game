using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
 
    public float playerSpeed;
    public float walkSpeed = 2f;
    public float mouseSensitivity = 2f;
    public float baseMouseSensitivity = 2f;
    private float yRot;
    public float baseDrag;
    public float newDrag;
    public float maxSpeed;
    public float backupMaxSpeed;
    public float baseMaxSpeed;
    public int playerNumber;
    public int isGoingForward;                  //1 = true, -1 = false
    public int yRotSlowDown;
 
    private Rigidbody rigidBody;
 
    void Start () {
        playerSpeed = walkSpeed;
        rigidBody = GetComponent<Rigidbody>();
        baseMouseSensitivity = mouseSensitivity;
        baseDrag = rigidBody.drag;
        baseMaxSpeed = maxSpeed;
    }
 
    void Update () {
        if (rigidBody.velocity.magnitude != 0) {
            if (rigidBody.velocity.magnitude * (mouseSensitivity / 8) < mouseSensitivity) {
                yRot += Input.GetAxisRaw("LeftJoystickX" + playerNumber) * (rigidBody.velocity.magnitude * (mouseSensitivity / 8) * isGoingForward);
            }
            else { 
                yRot += Input.GetAxisRaw("LeftJoystickX" + playerNumber) * mouseSensitivity * isGoingForward;
            }
            transform.eulerAngles = new Vector3(transform.localEulerAngles.x, yRot, transform.localEulerAngles.z);
        }
        Debug.Log(yRot);
 
        if(Input.GetButton("joystick " + playerNumber + " button 0") && Input.GetAxisRaw("RightTrigger" + playerNumber) > 0.5f && Input.GetAxisRaw("LeftJoystickX" + playerNumber) > 0.5f) {
            mouseSensitivity = baseMouseSensitivity * 1.5f;
            rigidBody.drag = newDrag;
        }
        else if (Input.GetButton("joystick " + playerNumber + " button 0") && Input.GetAxisRaw("LeftTrigger" + playerNumber) > 0.5f && Input.GetAxisRaw("LeftJoystickX" + playerNumber) < -0.5f) {
            mouseSensitivity = baseMouseSensitivity * 1.75f;
            rigidBody.drag = newDrag;
        }
        else if (!Input.GetButton("joystick " + playerNumber + " button 1")) {
            mouseSensitivity = baseMouseSensitivity;
            rigidBody.drag = baseDrag;
        }
        else {
            isGoingForward = -1;
            rigidBody.drag = newDrag;
            maxSpeed = backupMaxSpeed;
            if (rigidBody.velocity.magnitude <= maxSpeed) {
                rigidBody.velocity += transform.forward * playerSpeed * -1;
            }
        }
 
        if (Input.GetButton("joystick " + playerNumber + " button 0") && !Input.GetButton("joystick " + playerNumber + " button 1") && rigidBody.velocity.magnitude <= maxSpeed)
        {
            isGoingForward = 1;
            maxSpeed = baseMaxSpeed;
            rigidBody.velocity += transform.forward * playerSpeed;
        }
    }
}
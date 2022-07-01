using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5;

    [Header("Running")]
    public bool canRun = true;
    public bool IsRunning { get; private set; }
    public float runSpeed = 9;
    public KeyCode runningKey = KeyCode.LeftShift;

    Vector3 velocity;

    public bool isGrounded;

    Rigidbody rigidbody1;
    /// <summary> Functions to override movement speed. Will use the last added override. </summary>
    public List<System.Func<float>> speedOverrides = new List<System.Func<float>>();

    void update()
    {

        if (isGrounded == false)
        {
            velocity.y = -5f;
        }
    }

    void Awake()
    {
        // Get the rigidbody on this.
        rigidbody1 = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Update IsRunning from input.
        IsRunning = canRun && Input.GetKey(runningKey) && Input.GetKey("w");

        if (Input.GetKey(runningKey) && Input.GetKey("w") && Input.GetKey("a"))
        {
            canRun = false;
        }
        else if (Input.GetKey(runningKey) && Input.GetKey("w") && Input.GetKey("d"))
        {
            canRun = false;
        }
        else
        {
            canRun = true;
        }


        // Get targetMovingSpeed.
        float targetMovingSpeed = IsRunning ? runSpeed : speed;
        if (speedOverrides.Count > 0)
        {
            targetMovingSpeed = speedOverrides[speedOverrides.Count - 1]();
        }

        // Get targetVelocity from input.
        Vector2 targetVelocity = new Vector2(Input.GetAxis("Horizontal") * targetMovingSpeed, Input.GetAxis("Vertical") * targetMovingSpeed);

        // Apply movement.
        rigidbody1.velocity = transform.rotation * new Vector3(targetVelocity.x, rigidbody1.velocity.y, targetVelocity.y);
    }

}
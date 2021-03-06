using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CarController : MonoBehaviour
{
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";

    private float horizontalInput;
    private float verticalInput;
    private float currentsteerAngle;
    private float currentBreakForce;
    private bool isBreaking;

    private GetInCar getInCarScript;
    public float carMaxSpeed = 100;
    public float carCurrentSpeed = 0;

    Rigidbody rb;
    Transform trans;
    public static CarController cc;

    [SerializeField] private float motorForce;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSteeringAngle;

    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider frontRightWheelCollider;
    [SerializeField] private WheelCollider rearLeftWheelCollider;
    [SerializeField] private WheelCollider rearRightWheelCollider;

    [SerializeField] private Transform frontLeftWheelTransform;
    [SerializeField] private Transform frontRightWheelTransform;
    [SerializeField] private Transform rearLeftWheelTransform;
    [SerializeField] private Transform rearRightWheelTransform;

    private void Start()
    {
        getInCarScript = GameObject.Find("script-object").GetComponent<GetInCar>();

        cc = this;
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (getInCarScript.PlayerInCar)
        {
            GetInput();
        }
        HandleMotor();
        HandleSteering();
        UpdateWheels();

        Debug.Log(carCurrentSpeed);
    }

    void Unflip()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, trans.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
    }

    private void HandleMotor()
    {
        rearLeftWheelCollider.motorTorque = verticalInput * motorForce;
        rearRightWheelCollider.motorTorque = verticalInput * motorForce;

        carCurrentSpeed = (rb.velocity.magnitude * 3.6f) / carMaxSpeed;

        currentBreakForce = isBreaking ? breakForce : 0f;
        if (isBreaking)
        {
            ApplyBreaking();
            Debug.Log("break111");
        }
    }

    private void ApplyBreaking()
    {
        frontRightWheelCollider.brakeTorque = currentBreakForce;
        frontLeftWheelCollider.brakeTorque = currentBreakForce;
        rearLeftWheelCollider.brakeTorque = currentBreakForce;
        rearRightWheelCollider.brakeTorque = currentBreakForce;
    }

    private void GetInput()
    {
        verticalInput = Input.GetAxis(Vertical);
        horizontalInput = Input.GetAxis(Horizontal);
        isBreaking = Input.GetKey(KeyCode.Space);
    }

    private void HandleSteering()
    {
        currentsteerAngle = maxSteeringAngle * horizontalInput;
        frontLeftWheelCollider.steerAngle = currentsteerAngle;
        frontRightWheelCollider.steerAngle = currentsteerAngle;
    }

    private void UpdateWheels()
    {
        // frontLeftWheelTransform.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
        // frontRightWheelTransform.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);

        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(rearLeftWheelCollider, rearLeftWheelTransform);
        UpdateSingleWheel(rearRightWheelCollider, rearRightWheelTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
}

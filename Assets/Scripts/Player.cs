using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public WheelJoint2D rightWheel;
    public WheelJoint2D leftWheel;
    private JointMotor2D moto;

    [SerializeField] float motoSpeed;
    [SerializeField] float motoRotate;

    private Rigidbody2D motobody;

	void Start () {
        motobody = GetComponent<Rigidbody2D>();
        moto.maxMotorTorque = 10000;
       
		
	}
	
	
	void Update () {
        //moto.motorSpeed = -motoSpeed * Input.GetAxis("Vertical");
        moto.motorSpeed = -motoSpeed * Input.acceleration.y;
        rightWheel.motor = moto;
        leftWheel.motor = moto;
        //motobody.AddTorque(-motoRotate*Input.GetAxis("Horizontal")*Time.deltaTime);
        motobody.AddTorque(-motoRotate * Input.acceleration.y * Time.deltaTime);
	}
}

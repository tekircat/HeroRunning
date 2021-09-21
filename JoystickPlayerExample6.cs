using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JoystickPlayerExample6 : MonoBehaviour
{
	public float sensitivity = 300f;
	public float turnTreshold = 15f;
	private Vector3 mouseStartPos;

	protected Rigidbody rb;
	protected Vector3 curDir;
	protected Quaternion targetRot;

	public Slider PlayerSpeedSlider;

	//public float speed = 2f;
	public float turnSpeed = 14f;

	public float force;

	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
		
	}

	public  void Update()
	{
		//this.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);

		if(!EventSystem.current.IsPointerOverGameObject())
		{ 
		var mousePos = Input.mousePosition;
		if (Input.GetMouseButtonDown(0))
		{
			mouseStartPos = mousePos;
		}
		else if (Input.GetMouseButton(0))
		{
			float distance = (mousePos - mouseStartPos).magnitude;
			if (distance > turnTreshold)
			{
				if (distance > sensitivity)
				{
					mouseStartPos = mousePos - (curDir * sensitivity / 2f);
				}

				var curDir2D = -(mouseStartPos - mousePos).normalized;
				curDir = new Vector3(curDir2D.x, 0, 0.8f);
			}
		}
		else
		{
			curDir = new Vector3(Input.GetAxis("Horizontal"), 0, 1).normalized;
		}
		}
	}

	public  void FixedUpdate()
	{
		rb.AddForce(transform.forward * PlayerSpeedSlider.value, ForceMode.VelocityChange);

		if (curDir != Vector3.zero)
		{
			targetRot = Quaternion.LookRotation(curDir);
			if (rb.rotation != targetRot)
			{
				rb.rotation = Quaternion.RotateTowards(rb.rotation, targetRot, turnSpeed);
				//rb.AddForce(transform.forward * 6, ForceMode.VelocityChange);
			}
		}

	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Duvar"))
		{
			//transform.Translate(transform.right * Time.deltaTime * 40);
			//rb.AddForce(transform.right * speed, ForceMode.VelocityChange);
			//Player.gameObject.GetComponent<Rigidbody>().AddForce(-transform.up * -KickForce, ForceMode.Impulse);
			// Player.GetComponent<CapsuleCollider>().enabled = false;
			//jpe.enabled = false;
			//StartCoroutine(LateCall());

		}

	}
}

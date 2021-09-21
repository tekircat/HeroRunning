using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SinusoidalMove : MonoBehaviour {

	[SerializeField]
	float moveSpeed = 0f;

	public Slider EnemySpeedSlider;

	[SerializeField]
	float magnitude = 0.5f;

	bool facingRight = true;

	Vector3 pos, localScale;

	
	void Start () {
		
		pos = transform.position;

		localScale = transform.localScale;

	}
	
	// Update is called once per frame
	void Update () {
		
		CheckWhereToFace ();

		if (facingRight)
			MoveRight ();
		else
			MoveLeft ();
	}

	void CheckWhereToFace()
	{
		if (pos.x < -7f)
			facingRight = true;
		
		else if (pos.x > 7f)
			facingRight = false;

		if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
			localScale.x *= -1;

		transform.localScale = localScale;

	}

	void MoveRight()
	{
		pos += transform.right * Time.deltaTime * moveSpeed;
		transform.position = pos + transform.forward * Mathf.Sin(Time.time * EnemySpeedSlider.value) * magnitude;
	}

	void MoveLeft()
	{
		pos -= transform.right * Time.deltaTime * moveSpeed;
		transform.position = pos + transform.forward * Mathf.Sin(Time.time * EnemySpeedSlider.value) * magnitude;
	}

}

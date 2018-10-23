using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float jump;
	float moveVelocity;

	Rigidbody2D playerBody;

	bool isGrounded = true;

	void Start()
	{
		playerBody = GetComponent<Rigidbody2D>();
	}

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
		{
			if (this.isGrounded)
				playerBody.velocity = new Vector2(playerBody.velocity.x, jump);
		}

		moveVelocity = 0;

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			moveVelocity = -speed;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			moveVelocity = speed;
		}

		playerBody.velocity = new Vector2(moveVelocity, playerBody.velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		isGrounded = true;
	}

	void OnTriggerExit2D(Collider2D other)
	{
		isGrounded = false;
	}
}

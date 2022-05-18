using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderwaterMovement : MonoBehaviour // change name to player movement 
{
	private Rigidbody2D rb;
	private bool facingRight = true;
	public Plastic[] AllPlastic;
	public float horizontalSpeed = 10f;
	public float verticalSpeed = 10f;
	
	public Transform plastic;
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		// Move our character
		Move();
		
	}
	void Update()
    {
		if (Input.GetKeyDown(KeyCode.P))
		{
			swing();
		}
		AllPlastic = FindObjectsOfType<Plastic>(false);
	}

	void Move()
	{
		float horizontalDirection = Input.GetAxis("Horizontal");
		float verticalDirection = Input.GetAxis("Vertical");
		rb.velocity = new Vector2(horizontalDirection * horizontalSpeed, verticalDirection * verticalSpeed);

		// If the input is moving the player right and the player is facing left, then correct the character orientation
		if (horizontalDirection > 0 && !facingRight)
		{
			Flip();
		}

		// Otherwise if the input is moving the player left and the player is facing right, then correct the character orientation
		else if (horizontalDirection < 0 && facingRight)
		{
			Flip();
		}
	}
	void swing()
    {
		Debug.Log("Swinging!!!!!");
		double distance = 0.0;
		foreach(Plastic i in AllPlastic)
        {
			if (i.isPickup)
			{
				
				distance = Vector3.Distance(i.transform.position, transform.position);
				if(distance <= 2.0)
                {
					i.Destroy();
				}
				Debug.Log(distance);
			}

		}
			
			/*
			if (Vector3.Distance(PlayerPlaceHolder.transform.position, i.transform.position) >)
            {

            }
			*/
        
    }

	// Flips the horizontal orientation of the character
	private void Flip()
	{
		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;

		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
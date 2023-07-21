using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
	private void HandleMovement()
	{
		if (isLocalPlayer)
		{
			float x = Input.GetAxis("Horizontal");
			float z = Input.GetAxis("Vertical");
			Vector3 movement = new Vector3(x, 0, z);
			float moveSpeed = 5f;
			transform.position += movement * moveSpeed * Time.deltaTime;
		}
	}

	private void Update()
	{
		HandleMovement();
	}
}

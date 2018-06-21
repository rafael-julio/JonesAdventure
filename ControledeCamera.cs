using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControledeCamera : MonoBehaviour {

	private Vector2 velocity;

	public float delayX;
	public float delayY;

	public Transform player;


	public bool bounds;

	public Vector3 minCameraPos;
	public Vector3 maxCamerPos;

	
	// Update is called once per frame
	void FixedUpdate () {

		float posX = Mathf.SmoothDamp (transform.position.x, player.position.x, ref velocity.x, delayX);
		float posY = Mathf.SmoothDamp (transform.position.y, player.position.y, ref velocity.y, delayY);


				transform.position = new Vector3 (posX, posY, transform.position.z);


		if (bounds) {

			transform.position = new Vector3 (

				Mathf.Clamp(transform.position.x, minCameraPos.x, maxCamerPos.x),
				Mathf.Clamp(transform.position.y, minCameraPos.y, maxCamerPos.y),
				Mathf.Clamp(transform.position.z, minCameraPos.z, maxCamerPos.z)
			
			);
	}
	}
}



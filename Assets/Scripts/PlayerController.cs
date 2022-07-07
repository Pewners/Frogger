using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	//lives = 3
	public float minX = -3.46f;
	public float minY = -4.98f;
	public float maxX = 4.17f;
	public float maxY = 4.436f;


	void Start()
	{
		//spawn player at start
	}

	
	void Update()
	{

		if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minX)
		{
			//Debug.Log("Left");
			transform.Translate(Vector2.left);
			//if player > -4.03, -0.0057
				//dont move
		}

		if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxX)
		{
			//Debug.Log("Right");
			transform.Translate(Vector2.right);
		}

		if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY)
		{
			//Debug.Log("Up");
			transform.Translate(Vector2.up);
		}

		if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY)
		{
			//Debug.Log("Down");
			transform.Translate(Vector2.down);
		}

		
	}

	//void OnTriggerEnter2D (Collider2D col)
			//if player touches vehicle
				//kill player
				//lives = lives-1
				//respawn at start

			//if player touches finish
				//finish game
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
	public float minX = -3.46f;
	public float minY = -4.98f;
	public float maxX = 4.17f;
	public float maxY = 4.436f;

	public SpriteRenderer spriteRenderer;
	public Sprite up;
	public Sprite down;
	public Sprite left;
	public Sprite right;
	void ChangeSprite(Sprite down)
	{
		spriteRenderer.sprite = down;
	}

	void Start()
	{
		spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}

	
	void Update()
	{

		if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minX)
		{
			transform.Translate(Vector2.left);
            ChangeSprite(left);
		}

		if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxX)
		{
			transform.Translate(Vector2.right);
			ChangeSprite(right);
		}

		if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY)
		{
			transform.Translate(Vector2.up);
			ChangeSprite(up);
		}

		if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY)
		{
			transform.Translate(Vector2.down);
			ChangeSprite(down);
		}
	}
}

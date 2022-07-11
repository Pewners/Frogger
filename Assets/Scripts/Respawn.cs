using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public GameObject Player;
    public int lives = 6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives == 0)
        {
            SceneManager.LoadScene(5);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "End")
        {
            transform.position = (new Vector2 (0, -4));
        }

        if (col.tag == "Enemy")
        {
            lives = lives - 1;
            transform.position = (new Vector2(0, -4));
            Debug.Log(lives);
        }
    }
}

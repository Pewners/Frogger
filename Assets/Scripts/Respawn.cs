using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "End")
        {
            transform.position = (new Vector2 (0, -4));
        }

        if (col.tag == "Enemy")
        {
            //-1 life
            transform.position = (new Vector2(0, -4));
        }
    }
}

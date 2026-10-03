using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geo_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    private string _Ba = "Hello ";
    private int _num = 3;
    private Rigidbody2D rb;
    void Start()
    {
        Debug.Log(_Ba + "World");
        _Ba = "Goodbye ";
        Debug.Log(_Ba + "World");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(-1, rb.velocity.y);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(1, rb.velocity.y);
        }
          //   rb.velocity = new Vector2(-1, rb.velocity.y);
        // Debug.Log(_num);
        // num++;
        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        */
    }
}

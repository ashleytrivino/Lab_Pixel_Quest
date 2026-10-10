using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Geo_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    private string _Ba = "Hello ";
    private int _num = 3;
    private Rigidbody2D rb;
    public int _speed = 5;
    public string _NextLevel = "Level_2";
    private SpriteRenderer _spriteRenderer;
    void Start()
    {
        Debug.Log(_Ba + "World");
        _Ba = "Goodbye ";
        Debug.Log(_Ba + "World");
        rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * _speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _spriteRenderer.color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _spriteRenderer.color = Color.green;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _spriteRenderer.color = Color.blue;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(_NextLevel);
                    break;
                }

        }
    }
}

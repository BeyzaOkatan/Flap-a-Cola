using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cocacolascript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapStrength;
    public Logiscscript logic;
    public bool colaisAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logiscscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && colaisAlive)
        {
            myrigidbody.velocity = Vector2.up * flapStrength;
        }
        
        if(transform.position.y > 22 || transform.position.y < -22)
        {
            logic.gameOver();
            colaisAlive = false;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        colaisAlive = false;
    }
}

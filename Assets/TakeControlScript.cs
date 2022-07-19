using System;
using System.Collections.Generic;
using UnityEngine;

public class TakeControlScript : MonoBehaviour
{
    public Vector3 scaleChange;
    public Vector3 startPoint;
    public bool fallingBall;
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = startPoint;
        this.GetComponent<Rigidbody2D>().gravityScale = 0;
        fallingBall = false;
    }

    // Update is called once per frame
    void Update()
    {        
        
        if (!fallingBall)
        {
            if (Input.GetKey(KeyCode.RightArrow)&& (transform.localPosition.x <= -100))
            {
                transform.localPosition += scaleChange;
            }

            if ((Input.GetKey(KeyCode.LeftArrow))&& (transform.localPosition.x >= -350))
            {
                transform.localPosition -= scaleChange;
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.GetComponent<Rigidbody2D>().gravityScale = 6;            
            fallingBall = true;
        }

        

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Respawn"))
        {
            Debug.Log("hit the ground");
            transform.localPosition = startPoint;
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            this.GetComponent<Rigidbody2D>().gravityScale = 0;
            fallingBall = false;
        }
        if (other.gameObject.CompareTag("Finish"))
        {
            Debug.Log("putin dead");
            GameObject.Find("Circle").SetActive(false);
        }

    }


}

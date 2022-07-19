using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingScript : MonoBehaviour
{
    public Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if ((transform.localPosition.x > -100) || (transform.localPosition.x < -370))  scaleChange *= -1;       
        transform.localPosition += scaleChange * Time.deltaTime;
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            Debug.Log("putin dead");
            scaleChange = Vector3.zero;
            this.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            
        }

    }
}

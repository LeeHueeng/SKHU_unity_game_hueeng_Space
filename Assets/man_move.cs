using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class man_move : MonoBehaviour
{
    float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -3, 0);
    }

    // Update is called once per frame
    void Update()
    {
    

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Attack")
        {
            Destroy(gameObject);
        }
    }
}

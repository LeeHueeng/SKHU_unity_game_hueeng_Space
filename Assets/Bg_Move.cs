using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Bg_Move : MonoBehaviour
{
    float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed += 0.05f * Time.deltaTime;
        GetComponent<SpriteRenderer>().material.mainTextureOffset = new Vector2(0, speed);
    }
}

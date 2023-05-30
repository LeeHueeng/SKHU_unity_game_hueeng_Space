using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO_Ctrl : MonoBehaviour
{
    public GameObject pfUFO;
    float offsetTime = 3f;
    float currentTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > currentTime)
        {
            Instantiate(pfUFO, transform.position, transform.rotation);
            currentTime = Time.time + offsetTime;
        }
    }
}

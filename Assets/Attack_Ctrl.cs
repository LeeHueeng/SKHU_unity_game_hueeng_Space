using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Ctrl : MonoBehaviour
{
    public GameObject pfAttack;
    float offsetTime = 5f;
    float currentTime = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time>currentTime)
        {
            Instantiate(pfAttack, transform.position, transform.rotation);
            currentTime = Time.time + offsetTime;
        }
    }
 
}

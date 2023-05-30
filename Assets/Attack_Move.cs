using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class Attack_Move : MonoBehaviour
{
    float attackPosX = 0;
    float attackPosY = 0;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10.0f);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "man")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "gun")
        {
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        attackPosX = Random.Range(-3, 4) * Time.deltaTime * 1.5f;
        attackPosY = -3 * Time.deltaTime;
        transform.Translate(-attackPosX, attackPosY, 0);
    }

  

}

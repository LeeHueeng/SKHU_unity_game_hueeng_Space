
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bullet_Move : MonoBehaviour
{
    UI_Ctrl attackScore;
    public GameObject pfExplosion;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2.0f);
        attackScore = GameObject.Find("score").GetComponent<UI_Ctrl>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.05f, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Instantiate(pfExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(other.gameObject);
            attackScore.score += 20;
        }

        if (other.gameObject.tag == "Attack")
        {
            Instantiate(pfExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(other.gameObject);
            
        }

    }
}


    
   
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Ctrl : MonoBehaviour
{
    public float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Colisao : MonoBehaviour
{
    public GameObject main;
    public GameObject Vela2;
    public GameObject Vela3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("main"))
        {
            main.transform.position = new Vector2 (5,5); 
            Debug.Log("fsdfds");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class loadConfig : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject[] objetosInventario;

    void Start()
    {

        for (int i = 0; i < objetosInventario.Length; i++)
        {
            GameObject obj = Instantiate(objetosInventario[i], objetosInventario[i].transform.position, objetosInventario[i].transform.rotation);
            obj.transform.position = new Vector3(Random.Range(-10, 10), -2, Random.Range(-10, 10));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

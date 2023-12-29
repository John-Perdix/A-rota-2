using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class loadConfig : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject[] objetosInventario;

    /* void Start()
    {

        for (int i = 0; i < objetosInventario.Length; i++)
        {
            GameObject obj = Instantiate(objetosInventario[i], objetosInventario[i].transform.position, objetosInventario[i].transform.rotation);
            obj.transform.position = new Vector3(Random.Range(-10, 10), -2, Random.Range(-10, 10));
        }
    } */

    void Start()
{
    float radius = 5f;

    for (int i = 0; i < objetosInventario.Length; i++)
    {
        GameObject obj = Instantiate(objetosInventario[i], objetosInventario[i].transform.position, objetosInventario[i].transform.rotation);

        // Generate a random position
        Vector3 randomPosition;
        do
        {
            randomPosition = new Vector3(Random.Range(-10, 10), -3, Random.Range(-10, 10));
        } while (Vector3.Distance(randomPosition, Vector3.zero) < radius);

        // Set the object's position
        obj.transform.position = randomPosition;
    }
}

    // Update is called once per frame
    void Update()
    {

    }
}

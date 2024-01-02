/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bussola : MonoBehaviour
{
    public Transform playerTransform;
    public GameObject objecto;
    Vector3 dir;

    // Update is called once per frame
    private void Update()
    {
        dir.z = playerTransform.eulerAngles.y;
        transform.localEulerAngles = dir;
    }
} */

/* using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Bussola : MonoBehaviour
{
    public GameObject objecto;
    Vector3 dir;
    Vector3 relativeDir;

    // Update is called once per frame
    private void Update()
    {
        dir = objecto.transform.position;
        relativeDir = transform.parent.InverseTransformPoint(dir);
        
        float bussulaRotation = Mathf.Atan2(relativeDir.x, relativeDir.z) * Mathf.Rad2Deg;

        transform.localPosition = Quaternion.Euler(0, bussulaRotation,0);
    }
} */



//==========================TESTES==========================

/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bussola : MonoBehaviour
{
    public Transform objecto;

    // Update is called once per frame
    private void Update()
    {
        // Calculate the direction from the compass to the object
        Vector3 dirToObject = objecto.position - transform.position;

        // Calculate the rotation angle based on the direction
        float angle = Mathf.Atan2(dirToObject.y, dirToObject.x) * Mathf.Rad2Deg;

        // Set the rotation of the compass
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
} */

/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bussola : MonoBehaviour
{
    public List<GameObject> objectsToFollow = new List<GameObject>();

    // Update is called once per frame
    private void Update()
    {
        foreach (GameObject obj in objectsToFollow)
        {
            if (obj != null)
            {
                // Calculate the direction from the compass to the object
                Vector3 dirToObject = obj.transform.position - transform.position;

                // Calculate the rotation angle based on the direction
                float angle = Mathf.Atan2(dirToObject.y, dirToObject.x) * Mathf.Rad2Deg;

                // Set the rotation of the compass
                transform.rotation = Quaternion.Euler(0f, 0f, angle);

                // If you want only one object to be followed at a time, break the loop here
                break;
            }
        }
    }
} */


/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bussola : MonoBehaviour
{
    public Transform playerTransform;
    public List<GameObject> objectsToFollow = new List<GameObject>();
    private int currentIndex = 0;

    // Update is called once per frame
    private void Update()
    {
        if (objectsToFollow.Count > 0)
        {
            // Get the current target object
            GameObject currentTarget = objectsToFollow[currentIndex];

            // Check if the current target is active in the scene
            if (currentTarget != null && currentTarget.activeInHierarchy)
            {
                // Calculate the direction from the compass to the current target
                Vector3 dirToObject = currentTarget.transform.position - playerTransform.position;

                // Calculate the rotation angle based on the direction
                float angle = Mathf.Atan2(dirToObject.y, dirToObject.x) * Mathf.Rad2Deg;

                // Set the rotation of the compass
                transform.rotation = Quaternion.Euler(0f, 0f, angle);
            }
            else
            {
                // If the current target is not in the scene or not active, move to the next one
                currentIndex = (currentIndex + 1) % objectsToFollow.Count;
            }
        }
    }
} */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public List<Transform> targetPrefabs;
    public Transform compassArrow;
    public float rotationSpeed = 5f;

    private int currentIndex = 0;
    public Transform playerTransform; // Reference to the player's transform

    void Update()
    {
        if (targetPrefabs.Count > 0 && playerTransform != null)
        {
            UpdateCompassRotation();
        }
    }

    void UpdateCompassRotation()
    {
        // Get the direction to the current target
        Vector3 directionToTarget = targetPrefabs[currentIndex].position - transform.position;
        directionToTarget.Normalize();

        // Get the player's rotation
        float playerRotation = -playerTransform.eulerAngles.y;

        // Calculate the rotation angle relative to the player's rotation
        float angle = Mathf.Atan2(directionToTarget.y, directionToTarget.x) * Mathf.Rad2Deg - playerRotation;

        // Smoothly rotate the compass arrow towards the target
        Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
        compassArrow.rotation = Quaternion.Slerp(compassArrow.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }

    public void TargetDestroyed()
    {
        // Move to the next target in the list
        currentIndex = (currentIndex + 1) % targetPrefabs.Count;

        // Recalculate the direction to the new target
        UpdateCompassRotation();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public GameObject character;
    public float cameraDistance;

    private float initialRotation;
    private float initialHeight;
    // Start is called before the first frame update
    void Start()
    {
        initialHeight = transform.position.y;
        initialRotation = transform.rotation.eulerAngles.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(character.transform.position.x + -1 * cameraDistance * Mathf.Sin(Mathf.Deg2Rad * character.transform.rotation.eulerAngles.y), initialHeight, character.transform.position.z + -1 * cameraDistance * Mathf.Cos(Mathf.Deg2Rad * character.transform.rotation.eulerAngles.y));
        transform.rotation = Quaternion.Euler(initialRotation, 1 * character.transform.rotation.eulerAngles.y, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public GameObject character;
    public GameObject skipButton;


    public float cameraDistance;
    
    public float initCameraDistance;
    public float initCameraHeight;
    public float initCameraOrbitTime;
    public float initCameraOrbitAngle;
    public float xCenter;
    public float zCenter;

    private float timer;


    private float initialRotation;
    private float initialHeight;

    void Awake()
    {
        Time.timeScale = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        initialHeight = transform.position.y;
        initialRotation = transform.rotation.eulerAngles.x;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.unscaledDeltaTime;
        if (timer < initCameraOrbitTime)
        {
            
            float angle = timer / initCameraOrbitTime * 360;
            transform.position = new Vector3(xCenter + -1 * initCameraDistance * Mathf.Sin(Mathf.Deg2Rad * angle), initCameraHeight, zCenter + -1 * initCameraDistance * Mathf.Cos(Mathf.Deg2Rad * angle));
            transform.rotation = Quaternion.Euler(initCameraOrbitAngle, 1 * angle, 0);
        }
        else
        {
            skipButton.SetActive(false);
            Time.timeScale = 1;
            transform.position = new Vector3(character.transform.position.x + -1 * cameraDistance * Mathf.Sin(Mathf.Deg2Rad * character.transform.rotation.eulerAngles.y), character.transform.position.y + initialHeight, character.transform.position.z + -1 * cameraDistance * Mathf.Cos(Mathf.Deg2Rad * character.transform.rotation.eulerAngles.y));
            transform.rotation = Quaternion.Euler(initialRotation, 1 * character.transform.rotation.eulerAngles.y, 0);
        }
    }

    public void skipOrbit()
    {
        timer = initCameraOrbitTime;
    }
}

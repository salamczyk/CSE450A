using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warning : MonoBehaviour
{
    public float blinkDuration = 0.1f;
    public int blinkCount = 4;
    public float delayBetweenBlinks = 0.5f;
    public float timeToWaitForTriggering;

    private Renderer objectRenderer;
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        StartCoroutine(BlinkObject());
        objectRenderer.enabled = false;
    }

    IEnumerator BlinkObject()
    {
        yield return new WaitForSeconds(timeToWaitForTriggering);
        for (int i = 0; i < blinkCount; i++)
        {
            objectRenderer.enabled = true;
            yield return new WaitForSeconds(blinkDuration);
            objectRenderer.enabled = false;
            yield return new WaitForSeconds(delayBetweenBlinks);
        }
    }
}

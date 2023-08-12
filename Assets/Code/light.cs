using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    public static float savedIntensityMultiplier = 8f;

    private void Awake()
    {
        ApplyLightingSettings();
    }

    public static void ApplyLightingSettings()
    {
        RenderSettings.ambientIntensity = savedIntensityMultiplier;
    }
}



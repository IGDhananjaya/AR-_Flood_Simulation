using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainController : MonoBehaviour
{
    // Referensi ke Animator
    public Animator rainAnimator;

    // Nama parameter animator untuk intensitas hujan
    private string intensityParameter = "RainIntensity";

    // Method yang dipanggil saat nilai dropdown berubah
    public void ChangeRainAnimation(int intensityIndex)
    {
        // Set parameter animator berdasarkan indeks dropdown
        rainAnimator.SetInteger(intensityParameter, intensityIndex);
    }
}

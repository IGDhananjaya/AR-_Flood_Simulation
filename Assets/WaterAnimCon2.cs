using UnityEngine;
using Vuforia;

public class WaterAnimCon2 : DefaultObserverEventHandler
{
    public summon waterMovement;
    public AudioSource particleAudioSource; // Tambahkan referensi ke AudioSource

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();

        if (waterMovement != null && waterMovement.gameObject.activeInHierarchy)
        {
            string intensity = RainManager.Instance != null ? RainManager.Instance.GetRainIntensity() : "light";
            waterMovement.StartAnimation(intensity);

            // Mulai suara jika belum dimulai
            if (particleAudioSource != null && !particleAudioSource.isPlaying)
            {
                particleAudioSource.Play();
            }
        }
        else
        {
            StartCoroutine(WaitUntilActive());
        }
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();

        if (waterMovement != null)
        {
            waterMovement.ResetAnimation();
        }

        // Reset suara
        if (particleAudioSource != null)
        {
            particleAudioSource.Stop(); // Hentikan suara
            particleAudioSource.time = 0; // Reset waktu suara ke awal
        }
    }

    private System.Collections.IEnumerator WaitUntilActive()
    {
        yield return new WaitUntil(() => waterMovement != null && waterMovement.gameObject.activeInHierarchy);
        yield return null;

        // Perlu ambil intensitas lagi setelah aktif
        string intensity = RainManager.Instance != null ? RainManager.Instance.GetRainIntensity() : "light";
        waterMovement.StartAnimation(intensity);
    }
}
using UnityEngine;

public class OpenDriveLink : MonoBehaviour
{
    // Masukkan link preview Google Drive kamu di sini
    public string driveUrl = "https://drive.google.com/file/d/1NpEB4UPSnJs0Q6PYTKGoMjMl6wXyjMJa/view?usp=sharing";

    // Fungsi ini dipanggil lewat tombol
    public void OpenLink()
    {
#if UNITY_ANDROID
        try
        {
            // Ambil current activity dari Unity
            using (AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

                // Buat Uri dari link
                AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
                AndroidJavaObject uri = uriClass.CallStatic<AndroidJavaObject>("parse", driveUrl);

                // Intent VIEW → arahkan ke aplikasi Drive
                AndroidJavaObject intent = new AndroidJavaObject("android.content.Intent", "android.intent.action.VIEW", uri);
                intent.Call<AndroidJavaObject>("setPackage", "com.google.android.apps.docs");

                // Jalankan intent
                currentActivity.Call("startActivity", intent);

                UnityEngine.Debug.Log("✅ Membuka Google Drive app dengan link: " + driveUrl);
            }
        }
        catch (System.Exception e)
        {
            // Kalau gagal (misalnya Drive tidak ada) → fallback ke browser
            UnityEngine.Debug.LogWarning("⚠️ Gagal buka Drive app, fallback ke browser. Error: " + e.Message);
            UnityEngine.Application.OpenURL(driveUrl);
        }
#else
        // Di Unity Editor / PC langsung buka browser
        UnityEngine.Application.OpenURL(driveUrl);
        UnityEngine.Debug.Log("✅ Membuka link di browser: " + driveUrl);
#endif
    }
}

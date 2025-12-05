using UnityEngine;

public class TestButtonOpenURL : MonoBehaviour
{
    public void OpenGoogle()
    {
        UnityEngine.Application.OpenURL("https://www.google.com");
        UnityEngine.Debug.Log("👉 Button clicked, trying to open Google...");
    }
}

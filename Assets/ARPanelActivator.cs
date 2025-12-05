using UnityEngine;
using Vuforia;

public class ARPanelActivator : MonoBehaviour
{
    public GameObject rainInfoPanel; // Panel yang mau diaktifkan

    void Start()
    {
        // Pastikan panel awalnya tidak aktif
        if (rainInfoPanel != null)
            rainInfoPanel.SetActive(false);

        var observer = GetComponent<ObserverBehaviour>();
        if (observer)
        {
            observer.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED || targetStatus.Status == Status.EXTENDED_TRACKED)
        {
            rainInfoPanel.SetActive(true); // target terdeteksi ? panel muncul
        }
        else
        {
            rainInfoPanel.SetActive(false); // target hilang ? panel disembunyikan
        }
    }
}
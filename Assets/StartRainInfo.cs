using UnityEngine;

public class StartRainInfo : MonoBehaviour
{
    public RainInfoManager rainInfoManager;

    void Start()
    {
        if (rainInfoManager != null)
        {
            rainInfoManager.SetRainInfo("Light");
        }
    }
}
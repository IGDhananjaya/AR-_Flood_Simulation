using UnityEngine;

public class summon : MonoBehaviour
{
    [Header("Durasi dan Skala")]
    public float riseDuration = 3f;
    public float maxScaleTime = 10f;
    public float targetScaleX = 200f;
    public float originalWidth = 1f;

    private Vector3 initialLocalScale;
    private Vector3 initialLocalPosition;

    private float targetRiseY;
    private float elapsedTime = 0f;
    private bool rising = false;
    private bool scaling = false;

    void Start()
    {
        initialLocalScale = transform.localScale;
        initialLocalPosition = transform.localPosition;

        // Ambil intensitas terakhir dari RainManager
        string currentIntensity = RainManager.Instance != null ? RainManager.Instance.GetRainIntensity() : "light";
        StartAnimation(currentIntensity); // langsung animasikan
    }

    void Update()
    {
        if (rising)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / riseDuration);

            float newY = Mathf.Lerp(initialLocalPosition.y, targetRiseY, t);
            transform.localPosition = new Vector3(initialLocalPosition.x, newY, initialLocalPosition.z);

            if (elapsedTime >= riseDuration)
            {
                rising = false;
                elapsedTime = 0f;
                scaling = true;
            }
        }
        else if (scaling)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / maxScaleTime);

            float newScaleX = Mathf.Lerp(initialLocalScale.x, targetScaleX, t);
            transform.localScale = new Vector3(newScaleX, initialLocalScale.y, initialLocalScale.z);

            float deltaScaleX = newScaleX - initialLocalScale.x;
            float shiftX = -0.5f * deltaScaleX * originalWidth;

            transform.localPosition = new Vector3(initialLocalPosition.x + shiftX, transform.localPosition.y, initialLocalPosition.z);

            if (elapsedTime >= maxScaleTime)
            {
                scaling = false;
            }
        }
    }

    public void StartAnimation(string rainIntensity)
    {
        ResetAnimation();

        float riseHeight = 0f;
        switch (rainIntensity.ToLower())
        {
            case "light": riseHeight = 0f; break;
            case "medium": riseHeight = 1f; break;
            case "heavy": riseHeight = 2f; break;
            case "very heavy": riseHeight = 4f; break;
            default: riseHeight = 0f; break;
        }

        targetRiseY = initialLocalPosition.y + riseHeight;
        rising = true;
    }

    public void ResetAnimation()
    {
        elapsedTime = 0f;
        rising = false;
        scaling = false;
    }
}
using UnityEngine;
using Vuforia;

public class WaterAnimationHandler : DefaultObserverEventHandler
{
    public somon waterMovement;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();

        if (waterMovement != null && waterMovement.gameObject.activeInHierarchy)
        {
            waterMovement.StartMovement();
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
            waterMovement.ResetMovement();
        }
    }

    private System.Collections.IEnumerator WaitUntilActive()
    {
        yield return new WaitUntil(() => waterMovement != null && waterMovement.gameObject.activeInHierarchy);
        yield return null;
        waterMovement.StartMovement();
    }
}

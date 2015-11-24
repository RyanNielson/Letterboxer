using UnityEngine;

[ExecuteInEditMode, RequireComponent(typeof(Camera))]
public class Letterboxer : MonoBehaviour
{
    [SerializeField]
    private int targetAspectWidth = 1920;

    [SerializeField]
    private int targetAspectHeight = 1080;

    private int lastScreenWidth = -1;

    private int lastScreenHeight = -1;

    private new Camera camera;

    private void OnEnable()
    {
        camera = GetComponent<Camera>();
    }

    private void Update()
    {
        if (ShouldUpdateLetterbox())
        {
            lastScreenWidth = Screen.width;
            lastScreenHeight = Screen.height;

            UpdateLetterbox();
        }
    }

    private void UpdateLetterbox()
    {
        float targetAspect = targetAspectWidth / (float)targetAspectHeight;
        float windowAspect = lastScreenWidth / (float)lastScreenHeight;
        float scaleHeight = windowAspect / targetAspect;

        camera.rect = scaleHeight < 1.0f ? GetLetterboxRect(scaleHeight) : GetPillarboxRect(scaleHeight);
    }

    private Rect GetLetterboxRect(float scaleHeight)
    {
        return new Rect(0, (1f - scaleHeight) / 2f, 1f, scaleHeight);
    }

    private Rect GetPillarboxRect(float scaleHeight)
    {
        float scalewidth = 1.0f / scaleHeight;
        
        return new Rect((1f - scalewidth) / 2f, 0, scalewidth, 1f);
    }

    private bool ShouldUpdateLetterbox()
    {
        return Screen.width != lastScreenWidth || Screen.height != lastScreenHeight;
    }

    private void OnValidate()
    {
        targetAspectWidth  = Mathf.Max(1, targetAspectWidth);
        targetAspectHeight = Mathf.Max(1, targetAspectHeight);

        UpdateLetterbox();
    }
}

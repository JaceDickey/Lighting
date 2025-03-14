using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;
using TMPro;

public class PostProcessingSwitcher : MonoBehaviour
{
    public PostProcessVolume postProcessVolume;

    private Bloom bloom;
    private ColorGrading colorGrading;
    private Vignette vignette;

    public TextMeshProUGUI bloomText;
    public TextMeshProUGUI colorGradingText;
    public TextMeshProUGUI vignetteText;

    void Start()
    {
        if (postProcessVolume.profile.TryGetSettings(out bloom))
        {
            bloom.active = false;
        }
        if (postProcessVolume.profile.TryGetSettings(out colorGrading))
        {
            colorGrading.active = false;
        }
        if (postProcessVolume.profile.TryGetSettings(out vignette))
        {
            vignette.active = false;
        }

        UpdateUIText();
    }

    public void ToggleBloom()
    {
        if (bloom != null)
        {
            bloom.active = !bloom.active;
            UpdateUIText();
        }
    }

    public void ToggleColorGrading()
    {
        if (colorGrading != null)
        {
            colorGrading.active = !colorGrading.active;
            UpdateUIText();
        }
    }

    public void ToggleVignette()
    {
        if (vignette != null)
        {
            vignette.active = !vignette.active;
            UpdateUIText();
        }
    }

    private void UpdateUIText()
    {
        if (bloomText != null)
            bloomText.text = "" + (bloom.active ? "ON" : "OFF");

        if (colorGradingText != null)
            colorGradingText.text = "" + (colorGrading.active ? "ON" : "OFF");

        if (vignetteText != null)
            vignetteText.text = "" + (vignette.active ? "ON" : "OFF");
    }
}

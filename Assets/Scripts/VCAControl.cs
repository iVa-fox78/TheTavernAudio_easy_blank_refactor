using UnityEngine;
using UnityEngine.UI;

public class VCAControl : MonoBehaviour
{
    private FMOD.Studio.VCA vca;
    private Slider slider;

    [Header("Settings FMOD")]
    [SerializeField] private string vcaPath;
    [SerializeField] private string saveKey; //MusicVolume save. Save from the slider. Not that necessary thing but still

    [Header("Settings Volume")]
    [SerializeField] private float vcaVolume;
    void Start()
    {
        slider = GetComponent<Slider>();
        vca = FMODUnity.RuntimeManager.GetVCA(vcaPath);

        float saveVolume = PlayerPrefs.GetFloat(saveKey, 1); //Saving music Volume choose from Slider
        vca.getVolume(out vcaVolume);
        slider.value = saveVolume;
    }
    public void SetVolume(float volume)
    {
        vca.setVolume(volume);

        PlayerPrefs.SetFloat(saveKey, volume);
    }
}

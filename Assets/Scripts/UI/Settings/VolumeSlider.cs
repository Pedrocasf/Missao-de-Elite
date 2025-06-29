using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;

    private Slider slider;

    private void Awake()
    {
        slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener(OnValueChanged);
    }

    protected virtual void OnValueChanged(float value) 
    {
        float volume = value > 0 ? Mathf.Log10(value) * 20 : -80f;
        mixer.SetFloat("Volume", volume);
    }
}

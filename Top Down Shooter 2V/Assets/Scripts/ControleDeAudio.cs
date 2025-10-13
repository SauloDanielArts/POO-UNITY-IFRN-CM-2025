using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using Slider = UnityEngine.UI.Slider;

public class ControleDeAudio : MonoBehaviour
{
    public AudioMixer  audioMixer;
    public float volume = 0f;
    
    public Slider slider;
    public TMP_Text texto;
    
    
    void Start()
    {
        slider.minValue = -20;
        slider.maxValue = 20;
        slider.value = volume;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && volume < 20)
        {
            volume += 1;
        }
        
        if (Input.GetKeyDown(KeyCode.S) && volume > -80)
        {
            volume -= 1;
        }

        volume = slider.value;
        
        audioMixer.SetFloat("Master", volume);
        texto.text = volume.ToString();
    }
}

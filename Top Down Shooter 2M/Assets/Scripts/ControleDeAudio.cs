using UnityEngine;
using UnityEngine.Audio;

public class ControleDeAudio : MonoBehaviour
{
    public AudioMixer audioMixer;
    float masterVolume = 0;
    
    private AudioMixerGroup musicGroup;
    void Start()
    {
        musicGroup = audioMixer.FindMatchingGroups("Master")[0];
        
        audioMixer.GetFloat("Master", out masterVolume);
    }
 void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            masterVolume += 1f;
            audioMixer.SetFloat("Master", masterVolume);
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            masterVolume -= 1f;
            audioMixer.SetFloat("Master", masterVolume);
        }


    }
}

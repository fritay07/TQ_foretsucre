using UnityEngine;

public class AnimalClick : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void JouerSonAnimal()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}

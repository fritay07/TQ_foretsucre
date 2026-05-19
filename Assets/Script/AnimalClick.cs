using UnityEngine;

public class AnimalClick : MonoBehaviour
{
    public AudioClip sonDeLAnimal;
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if (sonDeLAnimal != null && !audioSource.isPlaying)
        {
            audioSource.PlayOneShot(sonDeLAnimal);
        }
    }
}
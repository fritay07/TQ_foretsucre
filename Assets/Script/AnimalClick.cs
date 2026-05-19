using UnityEngine;

public class AnimalClick : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnMouseDown()
    {
        
        if (audioSource != null && audioSource.clip != null)
        audioSource.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



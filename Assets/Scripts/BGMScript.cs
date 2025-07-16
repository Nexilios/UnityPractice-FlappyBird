using UnityEngine;

public class BGMScript : MonoBehaviour
{
    private static BGMScript _instance;
    private AudioSource _audioSource;

    private void Awake()
    {
        // If we already have one, destroy duplicates
        if (_instance && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject);

        _audioSource = GetComponent<AudioSource>();
        
        // Ensure it’s playing
        if (!_audioSource.isPlaying)
            _audioSource.Play();
    }
}

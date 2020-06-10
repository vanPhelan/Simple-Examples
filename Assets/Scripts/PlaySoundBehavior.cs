using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundBehavior : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    //Play when the GameObject is clicked
    public void OnMouseDown()
    {
        audioSource.Play();
    }
}

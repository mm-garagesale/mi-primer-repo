using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollide : MonoBehaviour
{
    public AudioSource audioSource = null;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
    }
}

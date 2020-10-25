using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audio : MonoBehaviour
{

    public AudioMixerSnapshot idleSnapshot;
    public AudioMixerSnapshot room1Snapshot;

    private void OnTriggerEnter(collider other)
    {

        if (other.CompareTag("Enemyzone"))
        {
            room1Snapshot.TransitionTo(0.5f);
        }
    }
    private void OnTriggerExit(collider other)
    {

        if (other.CompareTag("Enemyzone"))
        {
            idleSnapshot.TransitionTo(0.5f);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audio : MonoBehaviour
{
    public LayerMask waterholeM;
    public AudioMixerSnapshot idleSnapshot;
    public AudioMixerSnapshot room1Snapshot;

    private void OnTriggerEnter(Collider other)
    {
      print("enter;"+other.tag);

        if (other.CompareTag("Enemyzone"))
        {
            room1Snapshot.TransitionTo(0.5f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        print(other.tag);
        if (other.CompareTag("Enemyzone"))
        {
            idleSnapshot.TransitionTo(0.5f);
        }
    }
}
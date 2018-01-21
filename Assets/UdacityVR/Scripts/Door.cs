using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    private bool locked = true;
    // Create a boolean value called "opening" that can be checked in Update() 
    private bool opening = false;

    public AudioClip doorLocked;
    public AudioClip doorUnlocked;
    public Animator doorAnimator;
    public AudioSource doorAudioSource;

    void Update() {

        // If the door is opening and it is not fully raised
            // Animate the door raising up

        if (opening == true)
        {
            doorAnimator.Play("DoorOpen");
        }
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        if (locked == false)
        {
            opening = true;
            doorAudioSource.clip = doorUnlocked;
            doorAudioSource.Play();
        }
        // (optionally) Else
        // Play a sound to indicate the door is locked
        else
        {
            doorAudioSource.clip = doorLocked;
            doorAudioSource.Play();
        }
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        locked = false;
    }
}

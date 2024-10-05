using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
[RequireComponent(typeof(AudioSource))]
public class Goal : MonoBehaviour {
    //A static field accessible by code anywhere
    static public bool goalMet = false;
    private AudioSource audioSource;

    void Start() {
        // Get the AudioSource component attached to the Goal GameObject
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other) {
        //When the trigger is hit by something
        //Check to see if it's a Projectile
        Projectile proj = other.GetComponent<Projectile>();
        if(proj != null) {
            //If so, set goalMet to true
            Goal.goalMet = true;

            // Play the celebration sound
            if (!audioSource.isPlaying) {
                audioSource.Play();
            }
            
            //Also set the alpha of the color to a higher opacity
            Material mat = GetComponent<Renderer>().material;
            Color c = mat.color;
            c.a = 0.75f;
            mat.color = c;
        }
    }
}

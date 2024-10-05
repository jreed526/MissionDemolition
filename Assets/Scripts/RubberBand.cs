using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(LineRenderer))]
public class RubberBand : MonoBehaviour {
    public static GameObject projectile;
    public  GameObject leftArm;
    public  GameObject rightArm;
    public GameObject center;
    private LineRenderer band;
    void Awake() {
        band = GetComponent<LineRenderer>();
    }

    void Update() {
        if (projectile != null) {
            band.SetPosition(0, projectile.transform.position);
            band.SetPosition(1, transform.position);
        } else {
            band.SetPosition(0, center.transform.position);
            band.SetPosition(1, transform.position);
        }
    }
}

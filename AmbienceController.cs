using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceController : MonoBehaviour {

    public AudioClip Ambience1, Ambience2;
    public AudioSource source;

	// Use this for initialization
	void Start () {

        source.Play();

	}

    public void Update()
    {
        source.clip = Ambience1;
    }


}

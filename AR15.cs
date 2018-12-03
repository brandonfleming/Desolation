using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AR15 : MonoBehaviour {

    public float ClipAmmo = 32f;
    public float ReserveAmmo = 64f;
    public Text ClipUI, ReserveUI;
    public GameObject WeaponUI;
    public AudioSource reloadsound;

    //SHOOT FUNCTIONS

    public Animation ShootAnim;
    public AudioSource ShootSound;
    public float damage = 10f;
    public float range = 50f;
    public GameObject fpscam;
    public ParticleSystem blast;
    public GameObject ImpactEffect;
    //public float Firerate = 80f;

    //private float NextTimeToFire = 1f;


	// Use this for initialization
	void Start () {
		
	}

    void Shoot ()
    {
        Debug.Log("Shot");
        ClipAmmo = ClipAmmo - 1f;
        ShootAnim.Play();
        ShootSound.Play();
        blast.Play();
        if (ClipAmmo <= 0)
        {
            ShootAnim.Play("ar15reload");
            ReserveAmmo = ReserveAmmo - 32f;
            ClipAmmo = ClipAmmo + 32f;
            reloadsound.Play();
        }

        RaycastHit hit;

        if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range)) ;
        {
            Target target = hit.transform.gameObject.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
            if (target != null)
            {
                Debug.Log("Nothing found");
            }

            GameObject ImpactGO = Instantiate(ImpactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(ImpactGO, 2f);
        }
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
        {
            //NextTimeToFire = Time.deltaTime + 0.1f / Firerate;
            Shoot();
        }
        ReserveUI.text = ReserveAmmo.ToString();
        ClipUI.text = ClipAmmo.ToString();
	}
}

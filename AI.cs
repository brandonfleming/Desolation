using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    public Transform player;
    public GameObject zombie;
    public Rigidbody rb;
    public float moveSpeed = 100f;
    public float maxDistance = 15f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (Vector3.Distance(player.transform.position, gameObject.transform.position) <= maxDistance)
        {
            FollowPlayer();
        }

    }

    void FollowPlayer ()
    {
        zombie.transform.LookAt(player);

        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
}

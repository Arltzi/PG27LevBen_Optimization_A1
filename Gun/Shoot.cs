﻿using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject bullet;
    public GameObject spawnPos;
    public GameObject player;
    AudioSource gunSound;
    float shootCoolDown = 5f;

	void Start () {
        player = GameObject.Find("Player");
        gunSound = this.GetComponent<AudioSource>();
	}

    void ShootBullet()
    {
        //    Instantiate(bullet, spawnPos.transform.position, spawnPos.transform.rotation);
        //    gunSound.Play(); i could have just deleted this
        GameObject bullet = ObjectPooler.SharedInstance.GetPooledObject("bullet"); // yeah turret is capitalized and this isnt. boohoo 
        if (bullet != null)
        {
            bullet.transform.position = spawnPos.transform.position;
            bullet.transform.rotation = spawnPos.transform.rotation;
            bullet.SetActive(true);
        }
        gunSound.Play();
    }

    float turnSpeed = 1.0f;


	void Update () {

        if(player)
        {
            Vector3 direction = player.transform.position - this.transform.position;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                Quaternion.LookRotation(direction),
                                turnSpeed * Time.smoothDeltaTime);
            if (shootCoolDown <= 0)
            {
                ShootBullet();
                shootCoolDown = Random.Range(3,5);
            }
            else
                shootCoolDown -= Time.deltaTime;
        }
	}
}

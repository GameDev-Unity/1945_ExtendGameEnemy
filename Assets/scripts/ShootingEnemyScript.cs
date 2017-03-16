using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemyScript : EnemyScript
{
    public float ShootingEnemyScriptAcuracy = 1;
    public float FireRate = 0.2f;


    private GameObject[] players;
    private float nextFire = 0.0F;


    // Use this for initialization
    protected override void Start()
    {

        players = GameObject.FindGameObjectsWithTag("Player");
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
       foreach (var player in players)
        {
            // if enemy has player in front of him
            if (player.transform.position.y > transform.position.y - ShootingEnemyScriptAcuracy &&
                player.transform.position.y < transform.position.y + ShootingEnemyScriptAcuracy)
            {
                if (Time.time > nextFire)
                {
                    nextFire = Time.time + FireRate;
                    //Debug.Log("Enemy Shoot!");
                    GameObject bullet = (GameObject) Instantiate(Resources.Load("SmallBullet"));
                    bullet.GetComponent<BulletScript>().direction = BulletScript.Direction.Left;
                    bullet.transform.position = transform.position;
                    // offset to create bullet in front of plane
                    bullet.transform.position += new Vector3(-0.25f, 0, 0);
                }
            }

            
        }

        base.Update();
    }
}

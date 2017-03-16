using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using Random = System.Random;

public class SubmarineScript : EnemyScript
{
    private bool _x = true;
    private int _startTimer;
    public float EmergeDuration;
    private int _emergeRotation;
    private float _parralaxSpeed = .3F;
    public int HitPoints;
    private int _lostLife;

    private Random rand = new Random();
    private SoundEngine _soundEngine;


    // Use this for initialization
    protected override void Start()
    {
        _emergeRotation = rand.Next(1, 360);
        transform.Rotate(0, 0, _emergeRotation);
    }

    // Update is called once per frame
    protected override void Update()
    {
        _soundEngine = GameObject.FindGameObjectWithTag("SoundEngine").GetComponent<SoundEngine>();
        transform.position += new Vector3(-_parralaxSpeed * Time.deltaTime, 0, 0);

        if (_x)
        {
            _x = false;
            StartCoroutine(Wait(rand.Next(6, 13)));
            Debug.Log("waiting");
        }
    }

    protected override void OnTriggerEnter2D(Collider2D coll)
    {
        

        if (coll.gameObject.tag == "Bullet")
        {
            Debug.Log("Bullet colliosion on Submarine");
            if (_lostLife != HitPoints)
            {
                Debug.Log("Submarine lost one hit point");
                _lostLife++;
                //_soundEngine.SmallExplosion.Play();
            }
            else if (_lostLife == HitPoints)
            {
                Debug.Log("Submarine destroyed");
                _soundEngine.Explosion.Play();
                Destroy(gameObject);
            }
        }
    }

    IEnumerator Wait(float timer)
    {
        yield return new WaitForSeconds(timer);
        Destroy(gameObject);
        yield return 0;
    }
}

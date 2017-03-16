using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    private SoundEngine _soundEngine;
    // Use this for initialization


    protected virtual void Start () {
        _soundEngine = GameObject.FindGameObjectWithTag("SoundEngine").GetComponent<SoundEngine>();
    }
	
	// Update is called once per frame
	protected virtual void Update () {
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }

    protected virtual void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("Colliosion on Enemy detected");
        if (coll.gameObject.tag == "Bullet")
        {
            _soundEngine.Explosion.Play();
            Destroy(gameObject);
        }
            

    }

   
}

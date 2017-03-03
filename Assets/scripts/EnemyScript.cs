using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    private SoundEngine _soundEngine;
    // Use this for initialization
    public virtual void  Start () {
        _soundEngine = GameObject.FindGameObjectWithTag("SoundEngine").GetComponent<SoundEngine>();
    }
	
	// Update is called once per frame
	public virtual void Update () {
		transform.Translate (Vector2.left * Time.deltaTime);
    }

    public virtual void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("Colliosion on Enemy detected");
        if (coll.gameObject.tag == "Bullet")
        {
			coll.gameObject.GetComponent<BulletScript> ().owner.score++;
            _soundEngine.Explosion.Play();
            Destroy(gameObject);
        }
            

    }

   
}

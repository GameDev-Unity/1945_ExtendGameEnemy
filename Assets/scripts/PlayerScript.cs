using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float Speed;
    private SoundEngine _soundEngine;
    private Animator _animator;
    public string x_axis;
    public string y_axis;
    public string fire_axis;
    public float fireRate;
    private float nextFire = 0.0F;
	public int score = 0;

    // Use this for initialization
    void Start ()
    {
        _animator = GetComponent<Animator>();
        _soundEngine = GameObject.FindGameObjectWithTag("SoundEngine").GetComponent<SoundEngine>();
    }

    // Update is called once per frame
	void Update () {
		transform.Translate (new Vector2 (Input.GetAxis (x_axis) * Time.deltaTime * Speed, Input.GetAxis (y_axis) * Time.deltaTime * Speed));

        if (Input.GetAxisRaw(fire_axis) != 0 && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            //Debug.Log("Shoot!");
			GameObject bullet = (GameObject)Instantiate(Resources.Load("SmallBullet"));
			
			// offset to create bullet in front of plane
			bullet.transform.position = transform.position + Vector3.right * 0.25f;

            _soundEngine.Shot.Play();
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Colliosion on player detected");

        //if Collision with enemy player die
        if (other.gameObject.tag == "Enemy")
        {
            _soundEngine.Explosion.Play();
			_animator.SetBool ("exploded", true);
            Destroy(gameObject, 1);
        }
    }


}

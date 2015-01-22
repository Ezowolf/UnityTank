using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {
	public GameObject explosionPreFab;
	public int lives = 6;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter(Collision coll)
	{
		if(coll.gameObject.name == "Bullet(Clone)")
		{
			lives--;
			if(lives <= 0)
			{
				Instantiate(explosionPreFab, transform.position, transform.rotation);
				Destroy(this.gameObject);
			}
		}
	}
}

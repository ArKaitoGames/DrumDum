using UnityEngine;
using System.Collections;

public class ClickHandler : MonoBehaviour {

	public GameObject TheDrum;

	public AudioClip theSound;
	public AudioSource source;

	Touch touch;

	float TouchTime;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	 if (Input.GetMouseButtonDown(0)) {

			float vol = Random.Range (0.3f, 1.0f);
			source.PlayOneShot (theSound, vol);

			/***if (Input.GetMouseButtonUp(0)) {
				if (Time.time - TouchTime <= 0.5) {
					//response to tap
					print ("Tap was" + TouchTime + "seconds long.");

				} else {
					print ("Long press was" + TouchTime + "seconds long.");
				}
			}  ***/
		}
		if (Input.GetMouseButtonUp (0)) {
			source.Stop ();
		}

    }

	public void OnMouseDrag()
	{
		float distance_to_screen = Camera.main.WorldToScreenPoint(TheDrum.transform.position).z;
		Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen ));
		transform.position = new Vector3( pos_move.x, transform.position.y, pos_move.z );
		
	}


	
}


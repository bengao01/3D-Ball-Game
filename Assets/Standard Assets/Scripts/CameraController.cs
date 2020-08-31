using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
    private Vector3 offset;
     
    /* Use this for initialization. This calculates the difference between
     * the camera's position and the player. */
	void Start ()
    {
        offset = transform.position - player.transform.position;
	}
	
	/* Update is called once per frame. This always allows the player to follow
     * the player. The camera will be a set distance from the player.*/
	void LateUpdate ()
    {
        transform.position = player.transform.position + offset;
	}
}

using UnityEngine;
using System.Collections;

public class LeftMover : MonoBehaviour
{
	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		Vector3 left = new Vector3 (-1, 0, 0);
		rb.velocity = left * speed;
	}
}

using UnityEngine;
using System.Collections;

public class RightMover : MonoBehaviour
{
	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		Vector3 right = new Vector3 (1, 0, 0);
		rb.velocity = right * speed;
	}
}

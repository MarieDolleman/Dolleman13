using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		Vector3 forward = new Vector3 (0, 0, 1);

		rb.velocity = forward * speed;
	}
}

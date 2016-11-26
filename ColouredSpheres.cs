using UnityEngine;
using System.Collections;

public class ColoredSpheres : MonoBehaviour {

	public float sphereRadius = 0.0025f;

	// Use this for initialization
	void Start () {
		Transform transform = GetComponent<Transform>();
		Vector3 localScale = transform.localScale;
		Vector3 position = transform.position;
		Mesh mesh = GetComponent<MeshFilter>().mesh;
		Renderer renderer = GetComponent<Renderer>();
		renderer.enabled = false;

		GameObject container = GameObject.CreatePrimitive(PrimitiveType.Cube);

		for (var i = 0; i < mesh.vertices.Length; i++) {
			Vector3 vertex = mesh.vertices[i];
			Color color = mesh.colors[i];

			GameObject sphere = (GameObject)Instantiate(Resources.Load("Sphere"), Vector2.zero, Quaternion.identity);

			sphere.transform.localScale = new Vector3(sphereRadius, sphereRadius, sphereRadius);

			float x = (vertex.x * localScale.x);
			float y = (vertex.y * localScale.y);
			float z = (vertex.z * localScale.z);

			sphere.transform.position = new Vector3(x, y, z);
			sphere.GetComponent<Renderer>().material.color = color;
			sphere.GetComponent<Renderer>().material.SetColor("_EmissionColor", color);
			sphere.transform.parent = container.transform;
		}

		container.transform.position = position;
		container.transform.Rotate(transform.eulerAngles);
		container.GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

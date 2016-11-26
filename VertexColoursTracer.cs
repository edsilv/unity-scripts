using UnityEngine;
using System.Collections;

public class VertexColoursTracer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Mesh mesh = (GetComponent(typeof(MeshFilter)) as MeshFilter).mesh;
		print(mesh);
		foreach (Color color in mesh.colors) {
			print (color);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

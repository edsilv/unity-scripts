using UnityEngine;
using System.Collections;

public class PointCloud : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Mesh mesh = GetComponent<MeshFilter>().mesh;
		mesh.SetIndices(mesh.GetIndices(0), MeshTopology.Points, 0, true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

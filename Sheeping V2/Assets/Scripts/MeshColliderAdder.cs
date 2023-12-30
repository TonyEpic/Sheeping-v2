using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshColliderAdder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AddMeshCollidersRecursively(transform);
    }

    void AddMeshCollidersRecursively(Transform parent)
    {
        foreach (Transform child in parent)
        {
            // Check if the child already has a collider attached
            if (child.GetComponent<Collider>() == null)
            {
                // Add a MeshCollider to the child object if it has a MeshFilter
                MeshFilter meshFilter = child.GetComponent<MeshFilter>();
                if (meshFilter != null)
                {
                    MeshCollider meshCollider = child.gameObject.AddComponent<MeshCollider>();
                    meshCollider.sharedMesh = meshFilter.sharedMesh;
                }
            }

            // Recursively check and add colliders to all children
            AddMeshCollidersRecursively(child);
        }
    }
}

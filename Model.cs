using System;
using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;


public class Model
{
List<Vector3Int> faces = new List<Vector3Int>();
List<Vector3> vertices = new List<Vector3>();
public Model()
    {
        addVertices();
        addFaces();
    }

    private void addFaces()
    {
       faces.Add(new Vector3Int(1, 2, 4));//0
        faces.Add(new Vector3Int(3, 1, 4));//1
        faces.Add(new Vector3Int(0, 1, 3));//2
        faces.Add(new Vector3Int(0, 3, 8));//3
        faces.Add(new Vector3Int(0, 8, 10));//4
        faces.Add(new Vector3Int(8, 5, 6));//5
        faces.Add(new Vector3Int(8, 6, 9));//6
        faces.Add(new Vector3Int(6, 7, 9));//7
        faces.Add(new Vector3Int(10, 8, 11));//8
    
        faces.Add(new Vector3Int(2, 1, 4));//0
        faces.Add(new Vector3Int(4, 1, 3));//1
        faces.Add(new Vector3Int(1, 0, 3));//2
        faces.Add(new Vector3Int(3, 0, 8));//3
        faces.Add(new Vector3Int(8, 0, 10));//4
        faces.Add(new Vector3Int(6, 5, 8));//5
        faces.Add(new Vector3Int(9, 6, 8));//6
        faces.Add(new Vector3Int(7, 6, 9));//7
        faces.Add(new Vector3Int(11, 8, 10));//8
    }
    private void addVertices()
    {
        vertices.Add(new Vector3(-4, 8, -1));//0
        vertices.Add(new Vector3(3, 8, -1));//1
        vertices.Add(new Vector3(4, 7, -1));//2
        vertices.Add(new Vector3(-2, 6, -1));//3
        vertices.Add(new Vector3(4, 6, -1));//4

        vertices.Add(new Vector3(-2, 2, -1));//5
        vertices.Add(new Vector3(3, 2, -1));//6
        vertices.Add(new Vector3(4, 1, -1));//7

        vertices.Add(new Vector3(-2, 0, -1));//8
        vertices.Add(new Vector3(4, 0, -1));//9
        vertices.Add(new Vector3(-4, -8, -1));//10
        vertices.Add(new Vector3(-2, -8, -1));//11

        vertices.Add(new Vector3(-4, 8, 1));//0
        vertices.Add(new Vector3(3, 8, 1));//1
        vertices.Add(new Vector3(4, 7, 1));//2
        vertices.Add(new Vector3(-2, 6, 1));//3
        vertices.Add(new Vector3(4, 6, 1));//4

        vertices.Add(new Vector3(-2, 2, 1));//5
        vertices.Add(new Vector3(3, 2, 1));//6
        vertices.Add(new Vector3(4, 1, 1));//7
        
        vertices.Add(new Vector3(-2, 0, 1));//8
        vertices.Add(new Vector3(4, 0, 1));//9
        vertices.Add(new Vector3(-4, -8, 1));//10
        vertices.Add(new Vector3(-2,-8, 1));//11
        

    }



    public GameObject CreateUnityGameObject()
    {
        Mesh mesh = new Mesh();
        GameObject newGO = new GameObject();

        MeshFilter mesh_filter = newGO.AddComponent<MeshFilter>();
        MeshRenderer mesh_renderer = newGO.AddComponent<MeshRenderer>();

        List<Vector3> coords = new List<Vector3>();
        List<int> dummy_indices = new List<int>();
        /*List<Vector2> text_coords = new List<Vector2>();
        List<Vector3> normalz = new List<Vector3>();*/

        for (int i = 0; i < faces.Count; i++)
        {
            //Vector3 normal_for_face = normals[i];

            //normal_for_face = new Vector3(normal_for_face.x, normal_for_face.y, -normal_for_face.z);

            coords.Add(vertices[faces[i].x]); dummy_indices.Add(i * 3); //text_coords.Add(texture_coordinates[texture_index_list[i].x]); normalz.Add(normal_for_face);

            coords.Add(vertices[faces[i].y]); dummy_indices.Add(i * 3 + 2); //text_coords.Add(texture_coordinates[texture_index_list[i].y]); normalz.Add(normal_for_face);

            coords.Add(vertices[faces[i].z]); dummy_indices.Add(i * 3 + 1); //text_coords.Add(texture_coordinates[texture_index_list[i].z]); normalz.Add(normal_for_face);
        }

        mesh.vertices = coords.ToArray();
        mesh.triangles = dummy_indices.ToArray();
        /*mesh.uv = text_coords.ToArray();
        mesh.normals = normalz.ToArray();*/
        mesh_filter.mesh = mesh;

        return newGO;
    }


}

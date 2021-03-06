﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunklow : MonoBehaviour {

    private Mesh mesh;

    //面所需的点
    private List<Vector3> vertices = new List<Vector3>();
    //三边面所需的索引
    private List<int> triangles = new List<int>();

    // Use this for initialization
    void Start () {

        mesh = new Mesh();

        //添加面的点和索引
        AddFrontFace();
        AddBackFace();
        AddLeftFace();
        AddRightFace();
        AddTopFace();
        AddBottomFace();

        //赋值
        mesh.vertices = vertices.ToArray();
        mesh.triangles = triangles.ToArray();

        //重新计算顶点和法线
        mesh.RecalculateBounds();
        mesh.RecalculateNormals();

        //将生成的面赋值给组件
        GetComponent<MeshFilter>().mesh = mesh;

    }

    private void AddFrontFace()
    {
        //三角面1
        triangles.Add(0 + vertices.Count);
        triangles.Add(3 + vertices.Count);
        triangles.Add(2 + vertices.Count);

        //三角面2
        triangles.Add(2 + vertices.Count);
        triangles.Add(1 + vertices.Count);
        triangles.Add(0 + vertices.Count);

        //四点对象
        vertices.Add(new Vector3(0, 0, 0));
        vertices.Add(new Vector3(0, 0, 1));
        vertices.Add(new Vector3(0, 1, 1));
        vertices.Add(new Vector3(0, 1, 0));

    }

    private void AddBackFace()
    {
        //三角面1
        triangles.Add(0 + vertices.Count);
        triangles.Add(3 + vertices.Count);
        triangles.Add(2 + vertices.Count);

        //三角面2
        triangles.Add(2 + vertices.Count);
        triangles.Add(1 + vertices.Count);
        triangles.Add(0 + vertices.Count);

        //四点对象
        vertices.Add(new Vector3(-1, 0, 1));
        vertices.Add(new Vector3(-1, 0, 0));
        vertices.Add(new Vector3(-1, 1, 0));
        vertices.Add(new Vector3(-1, 1, 1));

    }

    private void AddLeftFace()
    {
        //三角面1
        triangles.Add(0 + vertices.Count);
        triangles.Add(3 + vertices.Count);
        triangles.Add(2 + vertices.Count);

        //三角面2
        triangles.Add(2 + vertices.Count);
        triangles.Add(1 + vertices.Count);
        triangles.Add(0 + vertices.Count);

        //四点对象
        vertices.Add(new Vector3(-1,  0, 0));
        vertices.Add(new Vector3( 0,  0, 0));
        vertices.Add(new Vector3( 0,  1, 0));
        vertices.Add(new Vector3(-1,  1, 0));

    }

    private void AddRightFace()
    {
        //三角面1
        triangles.Add(0 + vertices.Count);
        triangles.Add(3 + vertices.Count);
        triangles.Add(2 + vertices.Count);

        //三角面2
        triangles.Add(2 + vertices.Count);
        triangles.Add(1 + vertices.Count);
        triangles.Add(0 + vertices.Count);

        //四点对象
        vertices.Add(new Vector3( 0,  0, 1));
        vertices.Add(new Vector3(-1,  0, 1));
        vertices.Add(new Vector3(-1,  1, 1));
        vertices.Add(new Vector3( 0,  1, 1));

    }

    private void AddTopFace()
    {
        //三角面1
        triangles.Add(0 + vertices.Count);
        triangles.Add(3 + vertices.Count);
        triangles.Add(2 + vertices.Count);

        //三角面2
        triangles.Add(2 + vertices.Count);
        triangles.Add(1 + vertices.Count);
        triangles.Add(0 + vertices.Count);

        //四点对象
        vertices.Add(new Vector3( 0, 1, 0));
        vertices.Add(new Vector3( 0, 1, 1));
        vertices.Add(new Vector3(-1, 1, 1));
        vertices.Add(new Vector3(-1, 1, 0));

    }

    private void AddBottomFace()
    {
        //三角面1
        triangles.Add(0 + vertices.Count);
        triangles.Add(3 + vertices.Count);
        triangles.Add(2 + vertices.Count);

        //三角面2
        triangles.Add(2 + vertices.Count);
        triangles.Add(1 + vertices.Count);
        triangles.Add(0 + vertices.Count);

        //四点对象
        vertices.Add(new Vector3(-1, 0, 0));
        vertices.Add(new Vector3(-1, 0, 1));
        vertices.Add(new Vector3( 0, 0, 1));
        vertices.Add(new Vector3( 0, 0, 0));

    }



    // Update is called once per frame
    void Update () {
		
	}
}

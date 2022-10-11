using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    public GameObject cube;
    private Vector3 vecteurCube;
    // Start is called before the first frame update
    void Start()
    {
        vecteurCube = transform.position - cube.transform.position;
        Debug.Log(vecteurCube);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cube.transform.position + vecteurCube;
    }
}

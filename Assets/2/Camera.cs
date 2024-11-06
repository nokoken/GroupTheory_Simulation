using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = cube.transform.position + new Vector3(0.0f, 1.0f, -1.0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        MoveUpdate();
    }

    void MoveUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            this.transform.position += new Vector3(2.0f, 0.0f, 0.0f) * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.position += new Vector3(-2.0f, 0.0f, 0.0f) * Time.deltaTime;
        if (!Input.GetKey(KeyCode.UpArrow))
            this.transform.position += new Vector3(0.0f, 0.0f, -2.0f) * Time.deltaTime;
        if (!Input.GetKey(KeyCode.DownArrow))
            this.transform.position += new Vector3(0.0f, 0.0f, 2.0f) * Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RotatePall : MonoBehaviour
{
    [HideInInspector]
    public int palls_index = 0;
    [SerializeField]
    private List<GameObject> palls = new List<GameObject>();
    [SerializeField]
    private TextMeshProUGUI text;
    private float speed_factor = 0.1f;

    void Update()
    {
        text.text = (palls_index + 1).ToString();
        RotateCube();
        if (Input.GetKeyDown(KeyCode.LeftArrow) && palls_index - 1 >= 0)
            palls_index--;
        else if (Input.GetKeyDown(KeyCode.RightArrow) && palls_index < palls.Count - 1)
            palls_index++;
    }

    void RotateCube()
    {
        if (palls_index == 0)
            this.transform.RotateAround(this.transform.position, (this.transform.up + this.transform.right - this.transform.forward).normalized, 360.0f / (1 / speed_factor) * Time.deltaTime);
        else if (palls_index == 1)
            this.transform.RotateAround(this.transform.position, (this.transform.up - this.transform.right - this.transform.forward).normalized, 360.0f / (1 / speed_factor) * Time.deltaTime);
        else if (palls_index == 2)
            this.transform.RotateAround(this.transform.position, (this.transform.up - this.transform.right + this.transform.forward).normalized, 360.0f / (1 / speed_factor) * Time.deltaTime);
        else if (palls_index == 3)
            this.transform.RotateAround(this.transform.position, (this.transform.up + this.transform.right + this.transform.forward).normalized, 360.0f / (1 / speed_factor) * Time.deltaTime);
    }

}
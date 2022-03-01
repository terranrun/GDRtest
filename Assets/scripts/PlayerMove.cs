using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
            pos = Camera.main.ScreenToWorldPoint(pos);
            transform.position = pos;
        }
    }
}

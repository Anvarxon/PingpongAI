using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour {

    private void Update()
    {
        transform.position = new Vector2(transform.position.x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
    }
}

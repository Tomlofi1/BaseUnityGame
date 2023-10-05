using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointClicky : MonoBehaviour
{
    private Vector2 target;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);   
            target = new Vector2(mousePos.x, mousePos.y);

        }
        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * 5f);
    }
}

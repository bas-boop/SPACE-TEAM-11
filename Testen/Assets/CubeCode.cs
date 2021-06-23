using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCode : MonoBehaviour
{
    // Start is called before the first frame update
    private bool wasUp = false;
    private bool hasMoved = false;
    private float distanceCheckpoint = 0.01f;
    private bool gotPosition = false;
    private Vector3 positie;
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasMoved == false)
        {
            
            MoveUpDown();
        }

    }

    public void MoveUpDown()
    {
        

        if (wasUp == false)
        {
            MoveUp();
        }
        else
        {
            gotPosition = false;
            MoveDown();
        }
    }
    void MoveUp()
    {
        if (gotPosition == false)
        {
            positie = transform.position;
        }
        Vector3 pos = new Vector3(0, 2, 0) * Time.deltaTime;
        transform.position += pos;
        if (Vector3.Distance(transform.position, positie) < distanceCheckpoint)
        {
            wasUp = true;
            
        }
    }
    void MoveDown()
    {
        if (gotPosition == false)
        {
            positie = transform.position;
        }
        Vector3 pos = new Vector3(0, -2, 0) * Time.deltaTime;
        transform.position += pos;
        if (Vector3.Distance(transform.position, positie) < distanceCheckpoint)
        {
            hasMoved = true;
            
        }
    }
}

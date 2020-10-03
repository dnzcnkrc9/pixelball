using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    private Score scoreScript;
    public GameObject scoreObject;

    void Start()
    {
        scoreScript = scoreObject.GetComponent<Score>();

        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("point"))
        {
            //Debug.Log("Point!");
            scoreScript.point += 1;
        }
    }
}

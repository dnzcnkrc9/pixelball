using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsItActive : MonoBehaviour
{
    public GameObject o;
    public GameObject menuPanel;
    void Start()
    {
        menuPanel = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OActive()
    {
        o.SetActive(true);
    }
    public void ONotActive()
    {
        o.SetActive(false);
    }
}

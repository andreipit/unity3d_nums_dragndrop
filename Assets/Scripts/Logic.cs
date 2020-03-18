using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{
    public GameObject store;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleStore(bool show)
    {
        store.SetActive(show);
        if (show)
        {
            Debug.Log("open store");
        }
        else
        {
            Debug.Log("close store");
        }
    }
}

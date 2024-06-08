using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class triger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        string str = $"Enter {other.tag}";
        Debug.Log(str);
    }

    private void OnTriggerStay(Collider other)
    {
        string str = $"Stay {other.tag}";
        Debug.Log(str);
    }

    private void OnTriggerExit(Collider other)
    {
        string str = $"Leave {other.name}";
        Debug.Log(str);
    }
}

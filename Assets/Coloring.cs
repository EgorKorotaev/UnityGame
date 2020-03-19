using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coloring : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _renderer.material.color = Color.red;
            Debug.Log("Setting RED");
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            _renderer.material.color = Color.green;
            Debug.Log("Setting GrEeN");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            _renderer.material.color = Color.blue;
            Debug.Log("Setting Blue");
        }
    }
}
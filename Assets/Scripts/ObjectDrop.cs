using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDrop : MonoBehaviour
{
    [SerializeField]
    float _timeToWait = 3f;

    Rigidbody _rb;
    MeshRenderer _mRenderer;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _mRenderer = GetComponent<MeshRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _mRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > _timeToWait)
        {
            _mRenderer.enabled = true;
            _rb.useGravity = true; 
        }
    }
}

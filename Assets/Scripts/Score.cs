using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int _score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != Tags.OBJECT_HIT_TAG)
        {
            _score++;
            Debug.Log("You've bumped into things this many times: " + _score);
        }
        
    }
}

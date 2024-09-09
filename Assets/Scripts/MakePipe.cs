using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject Pipe;
    float timer = 0;
    public float timeDiff = 2.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeDiff)
        {
            GameObject newPipe = Instantiate(Pipe);
            newPipe.transform.position = new Vector3 (0, Random.Range(-8.25f, -0.52f), 0);
            timer = 0;
            Destroy(newPipe, 10);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public ParticleSystem particle;
    int count = 0;
    public int limitCount = 3;
    // Start is called before the first frame update
    void Start()
    {
        //particle = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            count++;
            if (count >= limitCount)
            {
                count = 0;
                particle.Play();
                Destroy(this.gameObject);
            }
        }
    }
}

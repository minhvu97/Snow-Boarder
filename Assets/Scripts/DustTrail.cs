using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustTrailParticle;
    SurfaceEffector2D surfaceEffector2D;
    private void Start()
    {
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }
    private void Update()
    {
        var main = dustTrailParticle.main;
        main.simulationSpeed = surfaceEffector2D.speed / 20;

    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            // dustTrailParticle.Stop();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            // dustTrailParticle.Play();
        }
    }
}

using UnityEngine;

public class SnowTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowParticles;

    void OnCollisionEnter2D(Collision2D collision)
    {
        int layerIdex = LayerMask.NameToLayer("Floor");

        if (collision.gameObject.layer == layerIdex)
        {
            snowParticles.Play();
        }
        
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        int layerIdex = LayerMask.NameToLayer("Floor");

        if (collision.gameObject.layer == layerIdex)
        {
            snowParticles.Stop();
        }
    }
}

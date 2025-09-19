using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetecttor : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1f;
    [SerializeField] ParticleSystem crashParticles;

    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");

        if (collision.gameObject.layer == layerIndex)
        {
            crashParticles.Play();
            Invoke("ReloadScene", reloadDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

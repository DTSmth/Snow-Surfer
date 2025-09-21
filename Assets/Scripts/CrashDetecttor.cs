using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetecttor : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1f;
    [SerializeField] ParticleSystem crashParticles;

    PlayerController playerController;


    void Start()
    {
        playerController = FindFirstObjectByType<PlayerController>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");

        if (collision.gameObject.layer == layerIndex)
        {
            playerController.canControlPlayer = false;
            crashParticles.Play();
            Invoke("ReloadScene", reloadDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetecttor : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");

        if (collision.gameObject.layer == layerIndex)
        {
            SceneManager.LoadScene(0);
        }
    }
}

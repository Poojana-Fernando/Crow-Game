using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LogoSceneController : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("LoadingScene");
    }
}

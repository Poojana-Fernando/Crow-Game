using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadingSceneController : MonoBehaviour
{
    public GameObject loadingIcon;
    public float rotateSpeed = 180f;
    public GameObject tapToStartText;

    private AsyncOperation operation;
    private bool isLoaded = false;
    private bool tapped = false;

    void Start()
    {
        tapToStartText.SetActive(false);
        loadingIcon.SetActive(true);
        StartCoroutine(LoadGame());
    }

    void Update()
    {
        if (!isLoaded && loadingIcon != null)
            loadingIcon.transform.Rotate(0f, 0f, -rotateSpeed * Time.deltaTime);

        if (isLoaded && !tapped && TapDetected())
        {
            tapped = true;
            StartCoroutine(ActivateScene());
        }
    }

    bool TapDetected()
    {
        if (Input.GetMouseButtonDown(0)) return true;
        return Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began;
    }

    IEnumerator ActivateScene()
    {
        tapToStartText.SetActive(false);
        yield return null; // let UI update
        operation.allowSceneActivation = true;
    }

    IEnumerator LoadGame()
    {
        operation = SceneManager.LoadSceneAsync("Game");
        operation.allowSceneActivation = false;

        while (operation.progress < 0.9f)
            yield return null;

        isLoaded = true;
        loadingIcon.SetActive(false);
        tapToStartText.SetActive(true);
    }
}

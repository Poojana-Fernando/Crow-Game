using UnityEngine;
using System.Collections;

public class GameBootstrap : MonoBehaviour
{
    public GameObject gameplayRoot; // parent of all heavy objects

    IEnumerator Start()
    {
        // scene activated, but heavy objects OFF
        if (gameplayRoot) gameplayRoot.SetActive(false);

        // wait a couple frames to avoid activation spike
        yield return null;
        yield return null;

        // now enable gameplay
        if (gameplayRoot) gameplayRoot.SetActive(true);
    }
}

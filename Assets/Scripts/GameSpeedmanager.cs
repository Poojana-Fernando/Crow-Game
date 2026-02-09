using UnityEngine;
using UnityEngine.Rendering;

public class GameSpeedmanager : MonoBehaviour
{
    public static float currentspeed;
    public float startspeed = 2f;
    public float maxspeed = 6f;
    public float speedRate = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentspeed = startspeed;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentspeed < maxspeed)
        {
            currentspeed += speedRate * Time.deltaTime;
            currentspeed = Mathf.Min(currentspeed,startspeed, maxspeed);
        }
        
    }
}

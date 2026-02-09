using UnityEngine;

public class FadeInOnStart : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator.SetTrigger("FadeOut");
    }
}

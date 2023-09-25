using UnityEngine;


[RequireComponent(typeof(Animator))]
public class AnimatorController : MonoBehaviour
{
     private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }


    

    public void PlayIdle()
    {
        _animator.Play("ww");
    }

    public void PlayRun()
    {
        _animator.Play("walking");
    }

   
}

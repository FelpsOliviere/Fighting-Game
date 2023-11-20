using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    public float currentMoveAnimation;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0 
            || Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0)
        {
            currentMoveAnimation += Time.deltaTime;
        }
        else
        {
            currentMoveAnimation -= Time.deltaTime;
        }

        animator.SetFloat("Movement", currentMoveAnimation);
    }
}

using UnityEngine;
using System.Collections;

public class MyAnimation : MonoBehaviour {
    public Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            animator.Play("WAIT04", -1, 0f);
        }
	}
}

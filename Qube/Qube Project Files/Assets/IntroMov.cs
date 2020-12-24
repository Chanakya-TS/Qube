using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroMov : MonoBehaviour
{
    private Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        //anim.Play("Menu");
    }

    // Update is called once per frame
}

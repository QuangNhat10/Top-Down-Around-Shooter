using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goblin : MonoBehaviour
{
    public Animator animator;
    private Vector3 lastPosition;

    void Start()
    {
        animator = GetComponent<Animator>();
        lastPosition = transform.position;
    }

    void Update()
    {
        // Lấy vận tốc di chuyển hiện tại
        float speed = (transform.position - lastPosition).magnitude / Time.deltaTime;

        // Nếu đang di chuyển -> bật animation Run, nếu đứng yên -> Idle
        animator.SetBool("isRun", speed > 0.05f);

        lastPosition = transform.position;
    }
}

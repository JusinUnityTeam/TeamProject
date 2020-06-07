using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayerCamera : MonoBehaviour
{
    public float m_fMoveSpeed = 1f;              // Player를 따라가는 속도

    private Transform m_Target;             // Player의 위치값 담는 
    private Vector3 m_Pos;                  // 자신의 위치

    // Start is called before the first frame update
    void Start()
    {
        // Player라는 태그를 가진 오브젝트의 transform을 가져온다.
        m_Target = GameObject.FindGameObjectWithTag("Player").transform;
        transform.Rotate(30f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        m_Pos = transform.position;
        transform.position += (m_Target.position - m_Pos) * m_fMoveSpeed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTankMovement : MonoBehaviour
{
    public float m_fMoveSpeed = 5f;         // 앞뒤 움직임 속도
    public float m_fRotateSpeed = 180f;     // 회전 속도

    // 키 입력 받을 값
    private float m_fMove;
    private float m_fRotate;
    private Rigidbody m_TankRigidbody; // 플레이어 캐릭터의 리지드바디

    // Start is called before the first frame update
    void Start()
    {
        m_TankRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    // FixedUpdate는 물리 갱신 주기에 맞춰 실행됨
    private void FixedUpdate()
    {
        // 회전 실행
        Turn();
        // 움직임 실행
        Move();
    }

    // 입력값에 따라 탱크를 앞뒤로 움직임
    private void Move()
    {
        // 상대적으로 이동할 거리 계산
        Vector3 moveDistance = Input.GetAxis("Vertical1") * transform.forward * m_fMoveSpeed * Time.deltaTime;
        // 리지드바디를 통해 게임 오브젝트 위치 변경
        m_TankRigidbody.MovePosition(m_TankRigidbody.position + moveDistance);
    }

    // 입력값에 따라 탱크를 좌우로 회전
    private void Turn()
    {
        // 상대적으로 회전할 수치 계산
        float turn = Input.GetAxis("Horizontal1") * m_fRotateSpeed * Time.deltaTime;
        // 리지드바디를 통해 게임 오브젝트 회전 변경
        m_TankRigidbody.rotation = m_TankRigidbody.rotation * Quaternion.Euler(0, turn, 0f);
    }
}

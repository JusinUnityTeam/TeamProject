using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAxis : MonoBehaviour
{
    public float m_ZoomSpeed = 5f;       // 줌 스피드
    public float m_fDistance = 10f;       // 카메라와의 거리 
    public float m_RotationSpeed = 5f;               // 회전 스피드

    // 마우스 회전
    public Quaternion m_TargetRotation;         // 최종적으로 축적된 Gap이 여기에 저장
    public Transform m_CameraVector;

    private Vector3 m_AxisVec;        // 축 벡터 
    private Vector3 m_Gap;           // 회전 축적 값

    private Transform m_MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        m_MainCamera = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Calculate_Zoom();
        Calculate_DistanceCamera();

        Rotate_Camera();
    }

    void Calculate_DistanceCamera()
    {
        m_AxisVec = transform.forward * -1;
        m_AxisVec *= m_fDistance;
        m_MainCamera.position = transform.position + m_AxisVec;
    }

    void Calculate_Zoom()
    {
        m_fDistance += Input.GetAxis("Mouse ScrollWheel") * m_ZoomSpeed * -1;
        m_fDistance = Mathf.Clamp(m_fDistance, 5f, 20f);
    }

    void Rotate_Camera()
    {
        if (transform.rotation != m_TargetRotation)
            transform.rotation = Quaternion.Slerp(transform.rotation, m_TargetRotation, m_RotationSpeed * Time.deltaTime);

        if (Input.GetMouseButton(1))
        {
            // 값을 축적.
            m_Gap.x += Input.GetAxis("Mouse Y") * m_RotationSpeed * -1;
            m_Gap.y += Input.GetAxis("Mouse X") * m_RotationSpeed;

            // 카메라 회전범위 제한.
            m_Gap.x = Mathf.Clamp(m_Gap.x, 10f, 85f);
            // 회전 값을 변수에 저장.
            m_TargetRotation = Quaternion.Euler(m_Gap);

            // 카메라벡터 객체에 Axis객체의 x,z회전 값을 제외한 y값만을 넘긴다.
            Quaternion q = m_TargetRotation;
            q.x = q.z = 0;
            m_CameraVector.transform.rotation = q;
        }

    }
}

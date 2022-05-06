using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadNotInWall : MonoBehaviour
{
    [SerializeField] private CapsuleCollider m_rigCollider;
    [SerializeField] private Transform m_cam;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = m_cam.localPosition;
        pos.y = m_rigCollider.height / 2;
        m_rigCollider.center = pos;
    }
}

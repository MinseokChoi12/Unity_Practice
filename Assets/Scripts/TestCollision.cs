using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // 1) 나 또는 상태한테 RigidBody가 있어야 한다 (IsKinematic : off)
    // 2) 나한테 Collider가 있어야 한다 (IsTrigger : off)
    // 3) 상대한테 Collider가 있어야 한다 (IsTrigger : off)
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision @ {collision.gameObject.name}!!");
    }

    // 범위를 판단할때
    // 1) 둘 다 Collider가 있어야 한다
    // 2) 둘 중 하나는 IsTrigger : On
    // 3) 둘 중 하나는 RigidBody가 있어야 한다
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Trigger @ {other.gameObject.name}!!");
    }

    void Start()
    {
        
    }

    void Update()
    {
        // Local <-> World <-> (Viewport <-> Screen) (화면)

        //Debug.Log(Input.mousePosition); // Screen 좌표 표현

        //Debug.Log(Camera.main.ScreenToViewportPoint(Input.mousePosition)); // Veiwport 좌표 표현

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);

            LayerMask mask = LayerMask.GetMask("Monster") | LayerMask.GetMask("Wall");
            //int mask = (1 << 8) | (1 << 9);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100.0f, mask))
            {
                Debug.Log($"Raycast Camera @ {hit.collider.gameObject.name}");
            }
        }

        //if (Input.GetMouseButtonDown(0))
        //{
        //    Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        //    Vector3 dir = mousePos - Camera.main.transform.position;
        //    dir = dir.normalized;

        //    Debug.DrawRay(Camera.main.transform.position, dir * 100.0f, Color.red, 1.0f);

        //    RaycastHit hit;
        //    if (Physics.Raycast(Camera.main.transform.position, dir, out hit, 100.0f))
        //    {
        //        Debug.Log($"Raycast Camera @ {hit.collider.gameObject.name}");
        //    }
        //}

        #region Raycasting #1
        //Vector3 look = transform.TransformDirection(Vector3.forward);
        //Debug.DrawRay(transform.position + Vector3.up, look * 10, Color.red); ;

        //RaycastHit[] hits;
        //hits = Physics.RaycastAll(transform.position + Vector3.up, Vector3.forward, 10);

        //foreach(RaycastHit hit in hits)
        //{
        //    Debug.Log($"Raycast {hit.collider.gameObject.name}!");
        //}

        // 광선과 하나만 충돌
        //if (Physics.Raycast(transform.position + Vector3.up, Vector3.forward, out hit, 10))
        //{
        //    Debug.Log($"Raycast {hit.collider.gameObject.name}!");
        //}
        #endregion

    }
}

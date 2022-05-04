using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Prototype5
{
    public class PlayerController : MonoBehaviour
    {
        public PolygonCollider2D holeCollider;
        public PolygonCollider2D groundCollider2D;
        public Collider groundCollider;
        public MeshCollider generatedMeshCollider;
        Mesh generatedMesh;

        public float initialScale = 0.5f;

        private void Start()
        {
            GameObject[] AllGOs = FindObjectsOfType(typeof(GameObject)) as GameObject[];
            foreach (var go in AllGOs)
            {
                if (go.layer == LayerMask.NameToLayer("Obstacles"))
                {
                    Physics.IgnoreCollision(go.GetComponent<Collider>(), generatedMeshCollider, true);
                }
            }
        }

        private void FixedUpdate()
        {
            if (transform.hasChanged == true)
            {
                transform.hasChanged = false;
                holeCollider.transform.position = new Vector3(transform.position.x, transform.position.z);
                holeCollider.transform.localScale = transform.localScale * initialScale;
                MakeHole2D();
                Make3DMeshCollider();
            }
        }

        private void MakeHole2D()
        {
            Vector2[] pointPositions = holeCollider.GetPath(0);

            for (int i = 0; i < pointPositions.Length; i++)
            {
                pointPositions[i] = holeCollider.transform.TransformPoint(pointPositions[i]);
            }

            groundCollider2D.pathCount = 2;
            groundCollider2D.SetPath(1, pointPositions);
        }

        private void Make3DMeshCollider()
        {
            if (generatedMesh != null) Destroy(generatedMesh);
            generatedMesh = groundCollider2D.CreateMesh(true, true);
            generatedMeshCollider.sharedMesh = generatedMesh;
        }

        private void OnTriggerEnter(Collider other)
        {
            Physics.IgnoreCollision(other, groundCollider, true);
            Physics.IgnoreCollision(other, generatedMeshCollider, false);
        }

        private void OnTriggerExit(Collider other)
        {
            Physics.IgnoreCollision(other, groundCollider, false);
            Physics.IgnoreCollision(other, generatedMeshCollider, true);
        }

        public void PlayerMove(BaseEventData myEvent)
        {
            if (((PointerEventData)myEvent).pointerCurrentRaycast.isValid)
            {
                transform.position = ((PointerEventData)myEvent).pointerCurrentRaycast.worldPosition;
            }
        }

        public IEnumerator ScaleHole()
        {
            Vector3 StartScale = transform.localScale;
            Vector3 EndScale = StartScale * 4;

            float t = 0;
            while (t <= 0.05f)
            {
                t += Time.deltaTime;
                transform.localScale = Vector3.Lerp(StartScale, EndScale, t);
                yield return null;
            }
        }
    }
}

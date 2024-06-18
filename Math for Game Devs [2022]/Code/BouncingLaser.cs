using System.Collections.Generic;
using UnityEngine;

namespace MathForGameDevs.Assignments
{
    public class AssignmentBounchingLaser : MonoBehaviour
    {
        public List<Transform> environmentVertexes;

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;

            for (int i = 0; i < environmentVertexes.Count; i++)
            {
                Transform first = environmentVertexes[i];
                Transform second = i == environmentVertexes.Count - 1 ? environmentVertexes[0] : environmentVertexes[i + 1];

                Gizmos.DrawLine(first.position, second.position);
            }
        }

        [ContextMenu("Get Vertexes")]
        public void GetVertexes()
        {
            environmentVertexes = new List<Transform>();

            Transform environment = transform.Find("Environment");

            for (int i = 0; i < environment.childCount; i++)
            {
                environment.GetChild(i).name = $"{i}";
                environmentVertexes.Add(environment.GetChild(i));
            }
        }
    }
}
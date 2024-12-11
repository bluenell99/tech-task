using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

[RequireComponent(typeof(NavMeshAgent))]
public class Agent : MonoBehaviour
{
   private NavMeshAgent _navMeshAgent;

   [SerializeField] private Transform[] _destinations;

   private void Awake()
   {
      _navMeshAgent = GetComponent<NavMeshAgent>();
   }

   private void Start()
   {
      StartCoroutine(RefreshDestination());
   }

   private IEnumerator RefreshDestination()
   {
       while (true)
       {
           yield return null;

           if (!_navMeshAgent.hasPath || _navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
           {
               yield return new WaitForSeconds(1f);
               GetNewDestination();
           }
       }
   }

   private void GetNewDestination()
   {
      Transform randomDest = _destinations[Random.Range(0, _destinations.Length)];

      _navMeshAgent.SetDestination(randomDest.position);
   }
}




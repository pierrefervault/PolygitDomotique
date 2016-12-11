using UnityEngine;
using System.Collections;

public class mouvementAspi : MonoBehaviour {

    public Vector3 dest;
    public float minX;
    public float minZ;
    public float maxX;
    public float maxZ;

    private NavMeshAgent agent;

    // Use this for initialization
    void Start () {
        agent = GetComponentInParent<NavMeshAgent>();
        randDest();
	}
	
	// Update is called once per frame
	void Update () {
        if (agent.remainingDistance < 0.5)
        {
            randDest();
        }
	}

    void randDest()
    {
        float randX = Random.RandomRange(minX, maxX);
        float randZ = Random.RandomRange(minZ, maxZ);
        dest = new Vector3(randX, transform.position.y, randZ);
        agent.SetDestination(dest);
    }
}

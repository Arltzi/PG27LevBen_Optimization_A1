using UnityEngine;

public class TurretDespawner : MonoBehaviour
{
    private void Start()
    {
        GetComponent<SphereCollider>().radius = TurretPlacer.Instance.turretGenRadius + 5.0f;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.position = 2 * other.transform.position - transform.position;
            transform.position = new Vector3(transform.position.x, 0.0f, transform.position.z);
        }
    }
}

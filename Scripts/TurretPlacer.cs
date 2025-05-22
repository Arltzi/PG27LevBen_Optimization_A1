using UnityEngine;
using UnityEngine.UIElements;

public class TurretPlacer : MonoBehaviour
{
  public float turretGenRadius = 100.0f;
  public int activeTurretCount = 100;

  public static TurretPlacer Instance { get; private set; }

  private void Awake()
  {
    if (Instance != null && Instance != this)
    {
      Destroy(this);
    }
    else
    {
      Instance = this;
    }
  }
  void Start()
  {
    for (int i = 0; i < activeTurretCount; i++)
    {
      ObjectPooler objectPooler = ObjectPooler.SharedInstance;
      GameObject turret = objectPooler.GetPooledObject("Turret");

      if (turret != null)
      {
        Vector2 spawnPositionXZ = Random.insideUnitCircle * turretGenRadius;
        turret.transform.position = new Vector3(spawnPositionXZ.x, 0.0f, spawnPositionXZ.y);
        turret.SetActive(true);
      }
    }
  }
}

using UnityEngine;

public class BulletMove : MonoBehaviour {

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    void Update()
    {
        this.transform.Translate(0, 0, 0.5f);
    }
}

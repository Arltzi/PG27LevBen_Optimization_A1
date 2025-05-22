using UnityEngine;

public class BulletMove : MonoBehaviour {

    void OnBecameInvisible()
    {
        // called when bullet flies out of camera.
        this.gameObject.SetActive(false); // go swimming
    }

    void Update()
    {
        this.transform.Translate(0, 0, 0.5f);
    }
}

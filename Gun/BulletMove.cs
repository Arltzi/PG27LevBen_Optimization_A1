using UnityEngine;

public class BulletMove : MonoBehaviour {

    void OnBecameInvisible()
    {
        this.gameObject.SetActive(false); // go swimming
    }

    void Update()
    {
        this.transform.Translate(0, 0, 0.5f);
    }
}

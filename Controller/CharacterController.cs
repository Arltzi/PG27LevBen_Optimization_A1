using UnityEngine;


public class CharacterController : MonoBehaviour {

	float speed = 10.0F;
	float rotSpeed = 80.0f;


	void Update () {
	
        float translation = Input.GetAxis("Vertical") * speed;
        float rotate = Input.GetAxis("Horizontal") * rotSpeed;
        translation *= Time.deltaTime;
        rotate *= Time.deltaTime;

        transform.Translate(0, 0, translation);
		transform.Rotate(0, rotate, 0);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;

	}
}

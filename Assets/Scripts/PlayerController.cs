using UnityEngine;

using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{

	public float speed;
	public TextMeshProUGUI countText;
	public GameObject winTextObject;

	private Rigidbody rb;
	private int count;
	private float movementX;
	private float movementY;

	void Start()
	{
		rb = GetComponent<Rigidbody>();

		count = 0;

		SetCountText();

		winTextObject.SetActive(false);
	}

	void FixedUpdate()
	{
		Vector3 movement = new Vector3(movementX, 0.0f, movementY);

		rb.AddForce(movement * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("PickUp"))
		{
			other.gameObject.SetActive(false);

			count = count + 1;

			SetCountText();
		}

		if (other.gameObject.CompareTag("TriggerWall"))
		{

			count = count - 1;

			SetCountText();
		}
	}

	void OnMove(InputValue value)
	{
		Vector2 v = value.Get<Vector2>();

		movementX = v.x;
		movementY = v.y;
	}

	void SetCountText()
	{
		countText.text = "Puntos: " + count.ToString();

		if (count >= 10)
		{
			winTextObject.SetActive(true);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BabyController : MonoBehaviour
{
    private bool isEnd = false;
    private GameObject GotchaText;
    private float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.GotchaText = GameObject.Find("GotchaText");
    }

    // Update is called once per frame
    void Update()
    {
        float pLocation = Time.time * speed / 4;
        transform.position = Vector3.Lerp(new Vector3(0, 0.25f, 2), new Vector3(0, 0.25f, 30), pLocation);
    }

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "UnityChanTag")
		{
            this.isEnd = true;
            this.GotchaText.GetComponent<Text>().text = "Gotcha!!!";
		}
	}
}

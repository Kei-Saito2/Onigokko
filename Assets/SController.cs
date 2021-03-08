using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SController : MonoBehaviour
{
    private GameObject scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("SText");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "UnityChanTag")
        {
            this.score += 10;
            this.scoreText.GetComponent<Text>().text = "S*** " + this.score + "pt";
            Destroy(gameObject);
        }
    }
}

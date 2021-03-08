using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SGenerator : MonoBehaviour
{
    public GameObject Baby;
    public GameObject SPrefab;
    private GameObject scoreText;
    private int score = 0;
    private float tmpTime = 0;
    private Vector3 CreatePos;

    // Start is called before the first frame update
    void Start()
    {
        this.Baby = GameObject.Find("B");
        this.scoreText = GameObject.Find("SText");
    }

    // Update is called once per frame
    void Update()
    {
        CreatePos = new Vector3(this.Baby.transform.position.x + Random.Range(0.1f, 1.0f),
            -10,
            this.Baby.transform.position.z + Random.Range(0.1f, 1.0f));
        tmpTime += Time.deltaTime;

        if (tmpTime >= 1)
        {
            int num = Random.Range(1, 3);
            if (num <= 2)
            {
                Instantiate(SPrefab, CreatePos, Quaternion.identity);
            }
            tmpTime = 0;
        }
    }
}

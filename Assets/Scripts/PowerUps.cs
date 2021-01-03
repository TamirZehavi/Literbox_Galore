using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{

    [SerializeField] private PlayerController cat;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "SpeedUp")
        {
            Destroy(gameObject);
            cat.playerSpeed += 20;

        }
        if (gameObject.tag == "SpeedDown")
        {
            Destroy(gameObject);
            cat.playerSpeed -= 20;
        }
    }


}
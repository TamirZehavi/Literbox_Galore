using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LitterBox : MonoBehaviour
{
    [SerializeField] private LitterBoxVictory red;
    [SerializeField] private LitterBoxVictory blue;
    [SerializeField] private LitterBoxVictory green;
    private int choose;

    // Start is called before the first frame update
    void Start()
    {
        choose = Random.Range(1, 4);
        AssignVictory();
    }

    private void AssignVictory()
    {
        if (choose == 1)
        {
            red.isVictory = true;
        }
        else if (choose == 2)
        {
            blue.isVictory = true;
        }
        
        else if (choose == 3)
        {
            green.isVictory = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
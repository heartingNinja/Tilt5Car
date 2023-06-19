using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject cube;
    public Material mat1;
    public Material mat2;

    // Update is called once per frame
    void Update()
    {
        if (TiltFive.Input.TryGetButtonDown(TiltFive.Input.WandButton.One, out bool onePressed, TiltFive.ControllerIndex.Right, TiltFive.PlayerIndex.One))
        {
            if (onePressed)
            {
                cube.GetComponent<MeshRenderer>().material = mat1;
            }
        }

        if (TiltFive.Input.TryGetButtonDown(TiltFive.Input.WandButton.Two, out bool twoPressed, TiltFive.ControllerIndex.Right, TiltFive.PlayerIndex.One))
        {
            if (twoPressed)
            {
                cube.GetComponent<MeshRenderer>().material = mat2;
            }
        }


    }
}

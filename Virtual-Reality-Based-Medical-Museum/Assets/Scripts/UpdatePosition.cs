using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePosition : MonoBehaviour
{
    public GameObject gameObjectToMove;

    public void UpdatePositionUrinary()
    {
        gameObjectToMove.transform.position = new Vector3(-15.94f, -0.92f, -1.4f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    
    void Update()
    {
        transform.Rotate(60*Time.deltaTime, 60*Time.deltaTime, 60*Time.deltaTime); //Update()는 매 초가 아닌 프레임. 따라서 Time.deltaTime을 통해 초마다로 변경해줌.
    }
}

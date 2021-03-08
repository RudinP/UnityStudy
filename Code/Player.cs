using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f; //speed변수 생성. public으로 unity에서 설정을 직접 할 수 있음
    private Rigidbody playerRigidbody; // Rigidbody컴포넌트를 가져옴.
    public GameManager gameManager; //GameManager 오브젝트를 가져옴
    void Start()
    {
  
        playerRigidbody = GetComponent<Rigidbody>(); //playerRigidbody를 private로 가져왔으므로 연결. 

    }

 
    void Update()
    {
        if (gameManager.isGameOver == true) return; //게임이 승리로 끝났을 경우 조작불가하도록

        float inputX, inputZ; 
        float fallspeed = playerRigidbody.velocity.y; //이렇게 원래의 낙하속도를 저장해두지 않고 0으로 만들어버리면 공이 낙하하지 않음

        inputX=Input.GetAxis("Horizontal"); //Input.GetAxis를 사용하면 조이스틱또한 적용 가능, 아날로그적 입력을 받기 위함임->그래서 -1.0~1.0 사이 값 float으로 받음
        inputZ = Input.GetAxis("Vertical"); 

        Vector3 velocity = new Vector3(inputX, 0, inputZ); //Vector3를 통해 벡터값을 받는 velocity 변수 설정
        velocity = velocity * speed; // (inputX*speed, 0, inputZ*speed)로 속도 지정
        velocity.y = fallspeed; // 0이 된 y축속도값을 원래의 중력을 받는 속도로 다시 돌려줌
        playerRigidbody.velocity = velocity; //playerRigidbody.velocity라는 컴포넌트 속 설정이 이미 있음, velocity 값으로 바꿔줌.

       
    }
}

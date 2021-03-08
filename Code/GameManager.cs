using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //씬 관리를 위함

public class GameManager : MonoBehaviour
{
    public ItemBox[] itemBoxes; //아이템박스 배열 만들기
    public bool isGameOver; //게임승리조건 만족했는지 설정하기 위한 불계수
    public GameObject WinUI; //겜오브젝트가져오기위한 변수. 실수로 대문자로 시작하도록 씀
    public AudioSource soundEffect; //오디오소스 가져오는 변수
    void Start()
    {
        isGameOver=false; //게임이 시작했을 땐 아직 게임을 승리할 수 없으므로 false로 설정
    }

    // Update is called once per frame
    void Update() //매 프레임마다
    {  if (Input.GetKeyDown(KeyCode.Space)) //Input.GetKeyDown은 눌렀을 당시 한번만 인식.cf)GetkeyUp은 키를 안누르고 있을 때, Getkey는 누르고 있는동안 계속 인식
            SceneManager.LoadScene(0); //해당 번호의 씬으로 이동. 자기자신씬이면 재시작. 씬 번호가 아닌, 씬의 이름을 넣어도 됨. 여기서는 "Main"
        if (isGameOver == true) return; //게임이 승리로 끝나면 더 이상 조작 불가를 위함

        int count = 0; //check값이 3개 모두 true인경우를 따지기 위한 변수
        for (int i = 0; i < 3; i++) //골이 모두 3개이므로 3번 반복.(배열의 원소 개수만큼 돌릴 수 있도록 하고싶으나, sizeof(itemboxes[])는 오류)
        {
            if (itemBoxes[i].check == true) 
                count++;
        }

        if (count >= 3) //모두 체크됐을경우
        {
            isGameOver = true; //게임종료
            WinUI.SetActive(true); //You Win! 이라는 txt를 화면에 띄우기 위함
            soundEffect.Play(); //게임 효과음 플레이(awake on start는 체크박스 해제해두자)
        }
    }
}

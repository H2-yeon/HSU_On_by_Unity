﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    Dictionary<string, string[]> talkData;

    void Awake()
    {
        talkData = new Dictionary<string, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        //talkData.Add("NPC, new string[]{}); 
        //talkData.Add("NPC_Yes, new string[]{});
        //talkData.Add("NPC_No, new string[]{});
        talkData.Add("TestNPC0", new string[] {
            "안녕 어서 와 ! HSU_ON에 온 걸 환영해 !!",
            "지금부터 내 소개를 해줄게 ! 나는 너희들의 오리엔테이션을 도와줄 상상부기야 ! 만나서 반가워 ~! ",
            "학교에 대해서 아직 잘 모르겠지만 이곳은 우리 한성대학교 캠퍼스를 똑같이 제작했어! ",
            "천천히 둘러보면서 우리학교의 건물들이 뭐가 있는지 잘 확인해봐! ",
            "자! 지금부터 나와 같이 몇 가지 미션을 진행할거야 ! 내가 미션을 주면 너가 수행한 다음에 나를 찾아오면 돼!",
            "미션을 완료하면 내가 스탬프를 하나씩 찍어주도록 하지 ! 모든 미션을 완료하면 상품이 기다리고 있으니 기대해도 좋아 ~ ",
            "바로 시작하자 ! 준비됐지 ? "
        });
        talkData.Add("TestNPC0_Yes", new string[]
        {
            "좋아 ~ 잘 선택했어! 위에 퀘스트 창이 생겼을 거야 ! 첫 번째 미션은 미래관 앞에 있는 나를 찾으면 알려줄게 ~ ",
            "응 ?? 미래관이 어딘지 모르겠다고 ? ",
            "미래관은 정문에서 바로 오른쪽에 보면 있을 거야 ! 그럼 기다리고 있을게 ~ "
        });
        talkData.Add("TestNPC0_No", new string[]
        {
            "흥! 어쩔 수 없지.. ",
            "준비가 되면 언제든 돌아와! 기다리고 있을게~ "
        });

        talkData.Add("TestNPC1", new string[] {
            "이 곳은 학생들이 자유롭게 공부할 수 있는 학술정보관, 미래관이야 ! ",
            "미래관 지하에는 그라찌에 카페와 문서들을 출력할 수 있는 프린터실이 구비되어있어!",
            "학술정보관 1층에는 열린 공간에서 공부할 수 있는 공간이 마련되어있고~ ",
            "2층과 3층은 각종 도서들을 대여할 수 있는 도서관, 팀프로젝트를 수행할 수 있는 공간이 있어 ! ",
            "그중에서도 대표적인 공간이라고 할 수 있는 곳은 바로 창의열람실이야! 창의열람실은 학술정보관 3층에 있지~ ",
            "그밖에도 4,5,6층에 친구들이 공부할 수 있는 집중열람실, 상상커먼스 등이 있어! 나중에 꼭 공부하러 오기다~? ",
            "자 이제 설명을 잘 들었는지 퀴즈를 낼거야! 준비됐지? 그럼 시작한다~! ",
            "학술정보관의 대표적인 시설 이름은?\n(힌트: ㅊㅇㅇㄹㅅ) "
        });
        talkData.Add("TestNPC1_Yes", new string[]{
            "정답!! ",
            "첫 번째 미션 클리어야! 이어서 두 번째 미션을 하고싶으면 상상관으로 오면 돼! 그럼 먼저 가서 기다리고 있을게~ "
        });
        talkData.Add("TestNPC1_No", new string[]{
            "틀렸어! 다시 한번 풀어볼까? ",
            "준비가 되면 다시 말을 걸어줘 ~ "
        });

        talkData.Add("TestNPC2_Sub", new string[]{
            "어서와~ 여기가 바로 상상관이야! ",
            "상상관은 우리학교의 가장 대표적 상징 건물이야! ",
            "건물 안으로 들어가면 나와 똑같은 상상부기가 상상관에 대해서 잘 설명해줄거야! ",
            "설명 후에는 퀴즈를 낸다고하니 정신 집중해서 설명듣고 퀴즈도 다 맞추고와 ! ",
        }); 
        talkData.Add("TestNPC2_Sub_Yes", new string[]{
            " "
        });
        talkData.Add("TestNPC2_Sub_No", new string[]{
            " "
        });

        talkData.Add("TestNPC2", new string[]{
            "안녕? 나는 원스톱지원센터를 지키고 있는 상상부기야! ",
            "상상관이 뭐하는 곳인지 지금부터 내가 잘 알려줄게! ",
            "우선 지금 너가 서 있는 곳이 바로 상상관 1층 원스톱지원센터야 ",
            "원스톱지원센터는 학교과의 소통을 위한 행정부서 학생들의 건의사항을 들어줄 수 있는 아주 중요한 기구지! ",
            "그리고 옆에 보이는 한성아키비움은 한성대학교의 역사를 담아둔 장소야 ",
            "직접 들어가보면 가슴이 웅장해질걸? 학교오면 꼭 방문해봐!! ",
            "그리고 2층에는 강의실과 우리학교 대표 카페 중 하나인 팥고당이 있어! ",
            "심지어 상상관 2층은 학술정보관, 우촌관을 지날 수 있는 통로까지 있다는 말씀! ",
            "상상관 3층에는 잘 돌아가고 빠른 노트북을 대여할 수 있는 통합기자재실이 있어! ",
            "웬만한 과제들은 문제없이 해결할 수 있어 노트북 없는 사람들에게 강추! ",
            "마지막으로 상상관 12층에가면 고급 레스토랑인 밀가옥과 전경이 아름다운 전망대도 있어! ",
            "스트레스를 받을 때 바라보면 바로 풀린다는 그 장소.. 사진으로 담은 경치가 이정도라구! ",
            "지금까지 상상관의 대표적인 시설을 알려줬어! 열심히 설명했으니 꼭 기억하기다? ",
            "자 이제 설명을 잘 들었는지 퀴즈를 낼거야! 준비됐지? 그럼 시작한다~! ",
            "지금 우리가 만난 곳인 상상관 1층에 위치하고 있으며, 학생들의 건의사항 및 궁금한 것들을 해소해주는 소통을 위한 행정부서의 명칭은?\n(힌트 : ㅇㅅㅌㅈㅇㅅㅌ) "
        });
        talkData.Add("TestNPC2_Yes", new string[]{
            "정답!! ",
            "두 번째 미션 클리어! 다음 세 번째 미션을 하고 싶으면 탐구관으로 찾아와! "
        });
        talkData.Add("TestNPC2_No", new string[]{
            "틀렸어! 다시 한번 풀어볼까? ",
            "준비가 되면 다시 말을 걸어줘 ~ "
        });

        talkData.Add("TestNPC3", new string[]{
            "오 잘 찾아왔네? 어서와! 이곳이 바로 탐구관이야 ",
            "개강하게되면 이 곳으로 수업을 많이 들으러 오게 될거야~ ",
            "조만간 수강신청을 진행하게 될텐데 새내기인 1학년 너희들은 필수교양인 영어커뮤니케이션, 삶과 꿈 등 ",
            "시간표가 짜여서 나오는 기초 필수 교양과목들을 이 곳 탐구관에서 듣게 될거야! ",
            "자 그럼 방금 내가 설명한 것을 기억하는지 테스트 해볼까? 준비해! 시작한다? ",
            "1학년 1학기 때 필수 기초 교양 과목으로 OOO와(과) 영어커뮤니케이션 과목을 수강한다. (띄어쓰기 X) "
        });
        talkData.Add("TestNPC3_Yes", new string[]{
            "정답!! 갑자기 퀴즈 내서 당황스러웠을텐데 내가 말한 내용을 잘 들었구나? ",
            "세 번째 미션 클리어! 다음 네 번째 미션을 하고 싶으면 연구관 상상파크로 찾아와! "
        });
        talkData.Add("TestNPC3_No", new string[]{
            "틀렸어! 다시 한번 풀어볼까? ",
            "준비가 되면 다시 말을 걸어줘 ~ "
        });

        talkData.Add("TestNPC4", new string[]{
            "어서와! 여기는 한성대생이 제일 애용하는 공간, 상상파크야! ",
            "주변을 둘러보면 우리학교의 대표 카페 중 하나인 그라찌에가  있고, 열린 환경의 공부할 수 있는 공간으로 구성되어있어! ",
            "그리고 상상파크에는 각종 3D 프린터가 구비되어있는 메이크 스페이스가 있어 각종 작품들을 만들어보는 체험을 할 수 있어! ",
            "혹시 VR과 AR에 관심있니? ",
            "상상파크 지하2층에는 가상현실과 증강현실을 체험할 수 있는  각종 기구들이 배치되어 보다 특별한 체험도 할 수 있다구~ ",
            "어때? 개강하면 꼭 와보고 싶지 않아? 상상부기는 언제나 환영할 준비가 되어있어! ",
            "자~ 이제 내가 내는 퀴즈를 맞춰봐! 답은 하나니깐 잘 골라봐~ ",
            "그라찌에, 상상 스테이지, VR & AR 멀티 스튜디오, 메이커 스페이스 중 상상파크에 있는 시설이 아닌 것은? (띄어쓰기 X)"
        });
        talkData.Add("TestNPC4_Yes", new string[]{
            "정답 ! 잘 찾아냈구나 !! ",
            "벌써 네 번째 미션 완료야! 개강하면 상상파크 꼭 와봐야한다~? ",
            "자! 이제 마지막 다섯 번째 미션만 남았어! 마지막 미션 장소는 바로 상상빌리지! 그럼 먼저가서 기다리고 있을게~ "
        });
        talkData.Add("TestNPC4_No", new string[]{
            "틀렸어! 다시 한번 풀어볼까? ",
            "준비가 되면 다시 말을 걸어줘 ~ "
        });
        talkData.Add("TestNPC5", new string[]{
            "어서와! 여기는 친구들을 위한 기숙사 상상빌리지야! ",
            "벌써 여기까지 왔네? 그럼 이제부터 상상빌리지에 대해 설명해주겠어! 잘 들어야한다? ",
            "먼저 여기 너가 서있는 곳은 바로 상상빌리지 입구인 1층이야! ",
            "상상빌리지는 지하 2층부터 7층까지 이루어져있어! ",
            "상상빌리지 입구로 들어오면 1층에 Smile Box인 무인 택배함이 마련되어있어! ",
            "택배 러버들에겐 정말 필수 시설이지~ ",
            "다음으로는 기숙사 외부 모습이야! 각 층마다 정수기가 배치되어있어 손쉽게 깨끗한 물을 마실 수 있다는 말씀! ",
            "그리고 1~3층은 남자 기숙사, 4~7층은 여자 기숙사로 구분되어있어~ 나중에 헷갈리지 말도록! ",
            "자 기숙사하면 편의시설을 빼먹을 수 없겠지? 지금부터 자세히 설명해주지! ",
            "지하 1층으로 내려오면 CU 편의점을 볼 수 있어! ",
            "지금은 무인으로 운영되고 있어 현금보다는 카드결제가 유용해! 참고하라구~ ",
            "편의점 옆에는 공동 휴게실이 마련되어있어! ",
            "이곳은 기숙사생들 뿐만아니라 한성대학교 학우라면 누구든지 와서 이용할 수 있지~ ",
            "휴게실 안으로 들어가면 이렇게 공동 취사실이 있어! ",
            "이 곳에는 인덕션, 에어프라이기, 전자레인지 등이 있어  여러 음식들을 조리할 수 있지~ ",
            "이외에도 지하 1층엔 세탁방, 독서실, 세미나실 등 학생들을 위한 시설들이 구성되어있어! ",
            "다음은 지하 2층으로 내려가보자! 지하 1층 중앙계단을 내려가 지하 2층에 도착하면 라켓볼장이 있어! ",
            "그 옆에는 탁구장이 있고~ ",
            "헬스를 좋아하는 사람들을 위한 공간인 체력 단련실이 있지~ ",
            "지하 2층은 보다 활동적인 공간들이 많아 운동을 좋아하는 학생들이 애용하는 곳이야! ",
            "이렇게 상상빌리지에 대한 설명은 여기서 마칠게! ",
            "자~ 이제 마지막 미션이지? 마지막 퀴즈니까 조금 만 더 힘내자 ! "
        });
        talkData.Add("TestNPC5_Yes", new string[]{
            "축하해~! 너는 오리엔테이션 모든 퀘스트를 클리어했어! ",
            "상상부기와 같이 가상 캠퍼스 투어한 소감이 어때? 얼른 학교로 오고싶지 않아? 아무튼 정말 고생 많았어 ^.^ ",
            "이제 가상 캠퍼스 공간 곳곳에 숨겨진 사물들을 찾아 히든 미션을 수행해봐! ",
            "아참! 그리고 우리를 만들어준 코딩하는쿼카 팀이 대동제 때 진행했던 미션들을 너는 지금부터 플레이 할 수 있어! ",
            "다만 대동제 미션을 클리어해도 인주가 다 떨어져서 도장은 못 찍어줄 것 같아..",
            "그래도 재미를 위해 플레이하고 싶다면 학술정보관 앞에있는 나를 찾아오면 돼! 그럼 먼저 가있는다~? "
        });
        talkData.Add("TestNPC5_No", new string[]{
            "틀렸어! 다시 한번 풀어볼까? ",
            "준비가 되면 다시 말을 걸어줘 ~ "
        });

        talkData.Add("HiddenNPC1", new string[]{
            "꼬꼬꾸 꼮꼬꼮 꼬꼬꾸꾼 !! 꾸꼬까 !! 꾸까 꼬꼬 꼬꼬 !!(드디어 우리를 발견했군!! 배고파!! 밥을 내놔라!!) ",
            "안내 메시지 : 꼬꾸&꾸꾸 번역기를 얻었다 ! ",
            "우리는 고고한 몸이라 아무나 주는 모이는 먹지 않는다 ! 모이를 주고 싶다면 퀴즈를 맞혀라 ! ",
            "우리는 한성대학교에서 아주 중요한 역할을 맡고 있다. ",
            "한성대학교의 마스코트이자 등교하는 학생들의 상쾌한 아침을 위한 '이것'을 진행하고 있지. ",
            "이것은 무엇인지 맞춰봐 !\n(띄어쓰기 X) "
        });
        talkData.Add("HiddenNPC1_Yes", new string[]{
           "너.. 너...! 진정한 우리의 팬이었꾸..! 우리에게 모이를 하사할 영광을 누리게 해주겠다꾸..! 냠냠! ",
           "첫 번째 히든 미션 꼬꼬&꾸꾸에게 모이주기 Clear! ",

        });
        talkData.Add("HiddenNPC1_No", new string[]{
           "우리에 대해 모르잖아 ?!! 다시 맞춰 볼 기회를 주도록 하지. ",
           "잘 모르겠다면 한성대학교 총학생회 인스타그램을 참고해보도록 ! "

        });

        talkData.Add("HiddenNPC2", new string[]{
            "역시 참새는 방앗간을 그냥 지나치지 않는군 후후.. ",
            "어서 와 여긴 상상파크 명물 그라지에 ! 두 번째 히든 미션 장소야. ",
            "내가 파는 메뉴들 중 생과일 요거트 메뉴에 없는 것을 찾는 거야 ! ",
            "아직 그라지에에 와보지 못한 친구들을 위해 힌트를 넣어뒀어 ! 그럼 잘 풀어보라구 ~~ ",
            "보기 : 포도, 키위, 블루베리, 딸기 \n( 힌트 : 비틀즈 보라색 )"

        });
        talkData.Add("HiddenNPC2_Yes", new string[]{
           "정답 ! 잘 찾아냈구나 !! ",
           "두 번째 히든 미션 완료야 ! 스탬프를 찍어 줬으니 확인해 보라구 ! ",

        });
        talkData.Add("HiddenNPC2_No", new string[]{
           "땡 ! 틀렸어.. ",
           "다시 풀어보자 ! ",
        });

        talkData.Add("HiddenNPC3", new string[]{
           "안녕 ? 나는 한성대학교 상징이자 수호신 현무 동상이야 ",
           "내 취미는 낱말 퍼즐 문제 풀기야 ~너도 한 번 풀어볼래 ? ",
           "퍼즐의 정답을 맞춘다면 세 번째 히든 미션 스탬프를 찍어줄게 ! ",
           "바로 시작하자 ! 준비됐지? ",
           "빈칸에 들어갈 낱말을 채워 완성된 단어를 입력해봐~ ",
           "대 □ 제 \n ( 힌트 : 한성대학교의 축제 명칭 )"

        });
        talkData.Add("HiddenNPC3_Yes", new string[]{
          "정답 ! 퍼즐 좀 풀 줄 아는데? ",
           "생각보다 잘 풀어서 놀랐는걸 ! ",
           "약속대로 세 번째 히든 미션 스탬프를 찍어줄게! ",
           "세 번째 히든 미션 클리어 ! "

        });
        talkData.Add("HiddenNPC3_No", new string[]{
           "흐음.. 틀렸어 ! 다시 한번 생각해 봐 ! ",
           "다시 풀어보자 ! "
        });

        talkData.Add("HiddenNPC4", new string[]{
            "어서 와라 야옹 ! 내 이름은 한성냥이다 야옹 ! ",
            "날 만난 이상 그냥 갈수 없다 야옹 ! ",
            "문제 좀 맞춰봐라 ",
            "한성대학교 장학팀 선생님 이름은? "
        });
        talkData.Add("HiddenNPC4_Yes", new string[]{
           "오 맞췄군 ! ",
           "네 번째 히든 미션 클리어 ! "
        });
        talkData.Add("HiddenNPC4_No", new string[]{
           "휴.. 숨 한번 돌리고 다시 말을 걸어라 야옹 ! "
        });

        talkData.Add("HiddenNPC5", new string[]{
            "거 젊은 친구 내가 계산을 잘 못해서 그런데 도와줄 수 있나? ",
            "지금까지 소시지 17개랑 맥주 15잔을 팔았는데 지금까지 매출이 얼마나 되는 거지? 계산 좀 해주겠나? ",
            "아 참 소시지는 하나에 1500원, 맥주는 3000원이라네 계산을 도와주면 고맙겠네 "

        });
        talkData.Add("HiddenNPC5_Yes", new string[]{
           "오호 고맙네 젊은이 ! 복받을 검세 ! ",
           "히든 미션 No.5 클리어! "
        });
        talkData.Add("HiddenNPC5_No", new string[]{
           "음.. 다시 한번 계산해 보겠나? "
        });

       
    }

    public string GetTalk(string name, int talkIndex)
    {
        return talkData[name][talkIndex];
    }
    public int getSize(string name)
    {
        return talkData[name].Length;
    }
}

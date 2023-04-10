﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 게임을 만들게 되면
// 큰 개념

// RPG
// 플레이어가 가질 수 있는 세부적인 내용들
// Gold
// 경험치
// 공격력
// 방어력
// 명사로 표현되는 것들은 대부분 멤버변수로 표현된다.


class Player
{
	// 내용을 채우는 것에 대한 이야기
	// 개념 : 플레이어는 골드를 가진다.
	// 세부속성이면서 명사면서 값인...

	// 멤버변수의 선언은 int(자료형) 이름(식별자)
	// 초기값(리터럴 값)을 넣어줄 수 있다.
	// 선언과 동시에 값을 넣어주는것 = 리터럴 초기화

	// exe 파일을 실행하면
	// 이 프로그램은 램에 올라가게 된다.(복사된다)

	// 프로그램 실행의 원칙
	// 1. 공짜가 없다(메모리라는 값을 지불함)
	// 2. exe 파일 자체는 하드디스크에 있다가 실행하면 램에 복사되게 됨.

	// 자료형의 의미
	// 크기 : 4바이트
	// 형태 : 정수
	// 이름의 의미
	// 위치 : 
	// 내가 사용하기 위한 별명
	// Gold -> 18923671622 번째
	// ATT -> 90 번째

	// 램의 90번지에 4바이트 만큼의 공간을 만들어라. == (int Att = 300)
	//		(ATT)
	// == "90번지에 300이라는 값을 채워넣어라."

	// 수학적 의미로는 이 녀석이 규칙이나 물리법칙.
	// 상수라고 부른다. 300

	// ecx 0x2163261 cpy 1826.3715626162 == int Att = 300;
	int Att = 300;
	int Gold = 10;
	int Exp = 1000;
	bool IsFight = true;	// 전투 가능 여부

	


}
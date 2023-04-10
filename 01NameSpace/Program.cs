using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 프로그래머가 2명이다.
// RPG를 만들기로 했다.

// 몬스터
// 무기
// 아이템

// A 프로그래머
// HP포션
// B 프로그래머
// MP포션

// 클래스의 이름 = 식별자
// 어떠한 코드적 내용을 묶는 하나의 명칭이다.
// 식별자가 겹칠때의 문제는 사용할 때이다.
// Potion 쓸게 -> 어떤포션인지 특정할 수 없음 (error)
// --> 네임스페이스는 개념의 표현이라기보다는 개념의 분류

// A프로그래머
namespace APRO
{
	class /* APRO. */Potion
	{
		// HP가 차는 내용
	}
}

// B프로그래머
namespace /* BPRO. */BPRO   // 보통 본인의 이니셜을 넣음
{
	class Potion    // 네임스페이스에 A프로그래머의 Potion을 넣으면 중복에러가 사라짐
	{
		// MP가 차는 내용
	}
}

class Player
{

}